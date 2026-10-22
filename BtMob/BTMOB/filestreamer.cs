using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace BTMOB;

public class filestreamer : HttpContent
{
	private HttpContent _content;

	private int _bufferSize;

	private IProgress<int> _progress;

	public filestreamer(HttpContent content, int bufferSize, IProgress<int> progress)
	{
		_content = content;
		_bufferSize = bufferSize;
		_progress = progress;
		foreach (KeyValuePair<string, IEnumerable<string>> header in content.Headers)
		{
			base.Headers.TryAddWithoutValidation(header.Key, header.Value);
		}
	}

	protected override async Task SerializeToStreamAsync(Stream stream, TransportContext context)
	{
		checked
		{
			byte[] array = new byte[_bufferSize - 1 + 1];
			using Stream stream2 = await _content.ReadAsStreamAsync();
			long length = stream2.Length;
			long num = 0L;
			while (true)
			{
				int num2 = await stream2.ReadAsync(array, 0, array.Length);
				if (num2 <= 0)
				{
					break;
				}
				await stream.WriteAsync(array, 0, num2);
				num += num2;
				int value = (int)Math.Round((double)(num * 100) / (double)length);
				_progress.Report(value);
			}
		}
	}

	protected override bool TryComputeLength(out long length)
	{
		length = _content.Headers.ContentLength.GetValueOrDefault();
		return true;
	}
}
