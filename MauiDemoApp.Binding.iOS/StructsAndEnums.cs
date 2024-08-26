// namespace MauiDemoApp.Binding.iOS {

// }
using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace Com.SAS.CI360
{
    [Native]
    public enum SASLoggerFlag : ulong //: nuint
    {
        Error = (1 << 0),
        Warning = (1 << 1),
        Info = (1 << 2),
        Debug = (1 << 3),
        Verbose = (1 << 4)
    }

    [Native]
    public enum SASLoggerLevel : ulong //: nuint
    {
        Off = 0,
        Error = (SASLoggerFlag.Error),
        Warning = (Error | SASLoggerFlag.Warning),
        Info = (Warning | SASLoggerFlag.Info),
        Debug = (Info | SASLoggerFlag.Debug),
        Verbose = (Debug | SASLoggerFlag.Verbose),
        //All = ((9223372036854775807L * 2) + 1)
        All = 18446744073709551615
        //All = 4294967295
    }

    static class CFunctions
    {
        // extern NSString * SASLoggerExtractFileNameWithoutExtension (const char *filePath, BOOL copy);
        [DllImport("__Internal")]
        //[Verify (PlatformInvoke)]
        static extern unsafe NSString SASLoggerExtractFileNameWithoutExtension(sbyte* filePath, bool copy);
    }

    [Native]
    public enum SASMobileMessageType : ulong //: nint
    {
        InAppMessage,
        PushNotification
    }
}
