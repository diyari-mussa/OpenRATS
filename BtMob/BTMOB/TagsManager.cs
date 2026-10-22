using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace BTMOB;

public class TagsManager
{
	private List<string> tags;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TagsManager()
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddTag(string tag)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveTag(string tag)
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<string> GetTags()
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LoadTags()
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SaveTags()
	{
		throw new AccessViolationException("Attempted to read or write protected memory. This is often an indication that other memory is corrupt.");
	}
}
