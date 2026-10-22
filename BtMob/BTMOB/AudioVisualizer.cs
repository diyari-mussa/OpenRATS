using System;
using System.IO;
using System.Media;
using System.Runtime.CompilerServices;
using System.Timers;
using DrakeUI.Framework;

namespace BTMOB;

public class AudioVisualizer
{
	private SoundPlayer audioPlayer;

	private Timer audioAmplitudeTimer;

	private DrakeUITrackBar progressBar;

	private int amplitude;

	private Random ran;

	public AudioVisualizer(DrakeUITrackBar progressBarControl)
	{
		amplitude = 0;
		progressBar = progressBarControl;
		audioPlayer = new SoundPlayer();
		audioAmplitudeTimer = new Timer(70.0);
		audioAmplitudeTimer.Elapsed += UpdateProgressBar;
		if (ran == null)
		{
			ran = new Random();
		}
	}

	public void Play(byte[] wavData)
	{
		using (MemoryStream stream = new MemoryStream(wavData))
		{
			audioPlayer.Stream = stream;
			audioPlayer.Play();
		}
		amplitude = ran.Next(10, 100);
		if (!audioAmplitudeTimer.Enabled)
		{
			audioAmplitudeTimer.Start();
		}
	}

	private void UpdateProgressBar(object sender, ElapsedEventArgs e)
	{
		if (amplitude > 0)
		{
			progressBar.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
			{
				progressBar.Value = amplitude;
				amplitude = 0;
			}));
		}
		if (progressBar.Value > 0)
		{
			progressBar.Value = checked(progressBar.Value - 1);
		}
	}

	public void StopVisualization()
	{
		audioAmplitudeTimer.Stop();
		progressBar.Value = 0;
	}
}
