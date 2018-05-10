﻿namespace PrimS.Telnet
{
  [IsNotDeadCodeAttribute]
  internal enum Options
  { 
    TransmitBinary = 0,
    Echo = 1,
    Reconnection = 2,
    SuppressGoAhead = 3,
    MessageSize = 4,
    Status = 5,
    TimingMark = 6,
    RemoteTransEcho = 7,
    LineWidth = 8,
    PageSize = 9,
    NAOCRD = 10,
    NAOHTS = 11,
    NAOHTD = 12,
    NAOFFD = 13,
    NAOVTS = 14,
    NAOVTD = 15,
    NAOLFD = 16,
    ExtendASCII = 17,
    Logout = 18,
    ByteMacro = 19,
    DataEntryTerminal = 20,
    SUPDUP = 21,
    SUPDUPOut = 22,
    SendLocation = 23,
    TerminalType = 24,
    EndOfRecord = 25,
    UserID = 26,
    OutputMark = 27,
    TerminalNumber = 28,
    Regime = 29,
    PAD = 30,
    WindowSize = 31,
    TerminalSpeed = 32,
    RemoteFlowControl = 33,
    LineMode = 34,
    XDisplay = 35,
    OldEnvironment = 36,
    Authentication = 37,
    NewEnvironment = 39,
    TN3270 = 40,
    XAUTH = 41,
    CharacterSet = 42,
    RemoteSerialPort = 43,
    COMPortControl = 44,
    SupressLocalEcho = 45,
    STARTTLS = 46,
    KERMIT = 47,
    URL = 48,
    ForwardX = 49,
    PRAGMA_LOGON = 138,
    SSPI_LOGON = 139,
    PRAGMA_HEARTBEAT = 140,
    ExtendedOptions = 255
  }
}
