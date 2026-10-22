// <PrivateImplementationDetails> reconstructed from Btmob.exe (v4.6.1).
// The VB.NET compiler emits this class for string-switch hashing
// (ComputeStringHash). ILSpy emitted an empty file for it, so the hash function
// is reimplemented here using the standard Roslyn/VB compiler algorithm.
// The decompiled sources reference it as global::_003CPrivateImplementationDetails_003E
// (the C# identifier-encoding of the IL name <PrivateImplementationDetails>),
// so the class is declared in the global namespace under that encoded name.
// The switch statements in BTConst.UpdateLanguage, Form1, and codes dispatch on
// ComputeStringHash values that were compiled against this exact algorithm.

using System.Runtime.CompilerServices;
using System.Threading.Tasks;

[CompilerGenerated]
internal sealed class _003CPrivateImplementationDetails_003E
{
    public static uint ComputeStringHash(string s)
    {
        unchecked
        {
            uint hash = 2166136261u;
            for (int i = 0; i < s.Length; i++)
            {
                hash = (hash ^ s[i]) * 16777619u;
            }
            return hash;
        }
    }
}

// The decompiled VB async code awaits TaskAwaiter<T> values directly
// (VB's Await works on awaiters). C# requires a GetAwaiter() method, which
// TaskAwaiter<T> lacks. This extension returns the awaiter itself, which
// already implements INotifyCompletion with IsCompleted/GetResult, making
// "await taskAwaiter;" valid C#.

namespace System.Runtime.CompilerServices
{
    internal static class TaskAwaiterExtensions
    {
        public static TaskAwaiter<T> GetAwaiter<T>(this TaskAwaiter<T> awaiter)
        {
            return awaiter;
        }

        public static TaskAwaiter GetAwaiter(this TaskAwaiter awaiter)
        {
            return awaiter;
        }
    }
}
