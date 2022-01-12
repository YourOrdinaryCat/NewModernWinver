﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewModernWinver
{
    class ListsAndStuff
    {
        public static Dictionary<int, string> BuildDict = new Dictionary<int, string>
        {
            { 10240, "1507" },
            { 10586, "1511" },
            { 14393, "1607" },
            { 15603, "1703" },
            { 16299, "1709" },
            { 17134, "1803" },
            { 17763, "1809" },
            { 18362, "1903" },
            { 18363, "1909" },
            { 19041, "2004" },
            { 19042, "20H2" },
            { 19043, "21H1" },
            { 19044, "21H2" },
            { 20348, "21H2" },
            { 21996, "Stop using leaked builds" },
            { 22000, "21H2" }

        };

        public static Dictionary<int, string> EditionDict = new Dictionary<int, string>
        {
            { 0x00000006, "Business" },
            { 0x00000010, "Business N" },
            { 0x00000012, "HPC Edition" },
            { 0x00000040, "Server Hyper Core V" },
            { 0x00000065, "Windows 10 Home" },
            { 0x00000063, "Windows 10 Home China" },
            { 0x00000062, "Windows 10 Home N" },
            { 0x00000064, "Windows 10 Home Single Language" },
            { 0x00000050, "Server Datacenter (evaluation installation)" },
            { 0x00000091, "Server Datacenter, Semi-Annual Channel Core" },
            { 0x00000092, "Server Standard, Semi-Annual Channel Core" },
            { 0x00000008, "Server Datacenter" },
            { 0x0000000C, "Server Datacenter Core" },
            { 0x00000027, "Server Datacenter without Hyper-V Core" },
            { 0x00000025, "Server Datacenter without Hyper-V" },
            { 0x00000079, "Windows 10 Education" },
            { 0x0000007A, "Windows 10 Education N" },
            { 0x00000004, "Windows 10 Enterprise" },
            { 0x00000046, "Windows 10 Enterprise E" },
            { 0x00000048, "Windows 10 Enterprise Evaluation" },
            { 0x0000001B, "Windows 10 Enterprise N" },
            { 0x00000054, "Windows 10 Enterprise N Evaluation" },
            { 0x0000007D, "Windows 10 Enterprise LTSC" },
            { 0x00000081, "Windows 10 Enterprise LTSC Evaluation" },
            { 0x0000007E, "Windows 10 Enterprise N LTSC" },
            { 0x00000082, "Windows 10 Enterprise N LTSC Evaluation" },
            { 0x0000000A, "Server Enterprise" },
            { 0x0000000E, "Server Enterprise Core" },
            { 0x00000029, "Server Enterprise without Hyper-V Core" },
            { 0x0000000F, "Server Enterprise for Itanium-based Systems" },
            { 0x00000026, "Server Enterprise without Hyper-V" },
            { 0x0000003C, "Windows Essential Server Solution Additional" },
            { 0x0000003E, "Windows Essential Server Solution Additional SVC" },
            { 0x0000003B, "Windows Essential Server Solution Management" },
            { 0x0000003D, "Windows Essential Server Solution Management SVC" },
            { 0x00000002, "Home Basic" },
            { 0x00000043, "Not supported" },
            { 0x00000005, "Home Basic N" },
            { 0x00000003, "Home Premium" },
            { 0x00000044, "Not supported" },
            { 0x0000001A, "Home Premium N" },
            { 0x00000022, "Windows Home Server 2011" },
            { 0x00000013, "Windows Storage Server 2008 R2 Essentials" },
            { 0x0000002A, "Microsoft Hyper-V Server" },
            { 0x0000007B, "Windows 10 IoT Core" },
            { 0x00000083, "Windows 10 IoT Core Commercial" },
            { 0x0000001E, "Windows Essential Business Server Management Server" },
            { 0x00000020, "Windows Essential Business Server Messaging Server" },
            { 0x0000001F, "Windows Essential Business Server Security Server" },
            { 0x00000068, "Windows 10 Mobile" },
            { 0x00000085, "Windows 10 Mobile Enterprise" },
            { 0x0000004D, "Windows MultiPoint Server Premium" },
            { 0x0000004C, "Windows MultiPoint Server Standard" },
            { 0x000000A1, "Windows 10 Pro for Workstations" },
            { 0x000000A2, "Windows 10 Pro for Workstations N" },
            { 0x00000030, "Windows 10 Pro" },
            { 0x00000045, "Not supported" },
            { 0x00000031, "Windows 10 Pro N" },
            { 0x00000067, "Professional with Media Center" },
            { 0x00000032, "Windows Small Business Server 2011 Essentials" },
            { 0x00000036, "Server For SB Solutions EM" },
            { 0x00000033, "Server For SB Solutions" },
            { 0x00000037, "Server For SB Solutions EM" },
            { 0x00000018, "Windows Server 2008 for Windows Essential Server Solutions" },
            { 0x00000023, "Windows Server 2008 without Hyper-V for Windows Essential Server Solutions" },
            { 0x00000021, "Server Foundation" },
            { 0x00000009, "Windows Small Business Server" },
            { 0x00000019, "Small Business Server Premium" },
            { 0x0000003F, "Small Business Server Premium Core" },
            { 0x00000038, "Windows MultiPoint Server" },
            { 0x0000004F, "Server Standard" },
            { 0x00000007, "Server Standard" },
            { 0x0000000D, "Server Standard Core" },
            { 0x00000028, "Server Standard without Hyper-V Core" },
            { 0x00000024, "Server Standard without Hyper-V" },
            { 0x00000034, "Server Solutions Premium" },
            { 0x00000035, "Server Solutions Premium Core" },
            { 0x0000000B, "Starter" },
            { 0x00000042, "Not supported" },
            { 0x0000002F, "Starter N" },
            { 0x00000017, "Storage Server Enterprise" },
            { 0x0000002E, "Storage Server Enterprise Core" },
            { 0x00000014, "Storage Server Express" },
            { 0x0000002B, "Storage Server Express Core" },
            { 0x00000060, "Storage Server Standard Evaluation" },
            { 0x00000015, "Storage Server Standard" },
            { 0x0000002C, "Storage Server Standard Core" },
            { 0x0000005F, "Storage Server Workgroup Evaluation" },
            { 0x00000016, "Storage Server Workgroup" },
            { 0x0000002D, "Storage Server Workgroup Core" },
            { 0x00000001, "Ultimate" },
            { 0x00000047, "Not supported" },
            { 0x0000001C, "Ultimate N" },
            { 0x00000000, "An unknown product" },
            { 0x00000011, "Web Server" },
            { 0x0000001D, "Web Server Core" }

        };
    }
}
