using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace EspTouchBinding
{
	// @interface ESPDataCode : NSObject
	[BaseType(typeof(NSObject))]
	interface ESPDataCode
	{
		// -(NSData *)getBytes;
		[Export("getBytes")]
		NSData Bytes { get; }

		// -(id)initWithU8:(UInt8)u8 andIndex:(int)index;
		[Export("initWithU8:andIndex:")]
		IntPtr Constructor(byte u8, int index);
	}

	// @interface ESPDatumCode : NSObject
	[BaseType(typeof(NSObject))]
	interface ESPDatumCode
	{
		// -(id)initWithSsid:(NSString *)apSsid andApBssid:(NSString *)apBssid andApPwd:(NSString *)apPwd andInetAddrData:(NSData *)ipAddrData andIsSsidHidden:(BOOL)isSsidHidden;
		[Export("initWithSsid:andApBssid:andApPwd:andInetAddrData:andIsSsidHidden:")]
		IntPtr Constructor(string apSsid, string apBssid, string apPwd, NSData ipAddrData, bool isSsidHidden);

		// -(NSData *)getBytes;
		[Export("getBytes")]
		NSData Bytes { get; }

		// -(NSData *)getU16s;
		[Export("getU16s")]
		NSData U16s { get; }
	}

	// @interface ESPGuideCode : NSObject
	[BaseType(typeof(NSObject))]
	interface ESPGuideCode
	{
		// -(NSData *)getU16s;
		[Export("getU16s")]
		NSData U16s { get; }
	}

	// @interface ESPTouchResult : NSObject
	[BaseType(typeof(NSObject))]
	interface ESPTouchResult
	{
		// @property (assign, nonatomic) BOOL isSuc;
		[Export("isSuc")]
		bool IsSuc { get; set; }

		// @property (nonatomic, strong) NSString * bssid;
		[Export("bssid", ArgumentSemantic.Strong)]
		string Bssid { get; set; }

		// @property (assign, atomic) BOOL isCancelled;
		[Export("isCancelled")]
		bool IsCancelled { get; set; }

		// @property (atomic) NSData * ipAddrData;
		[Export("ipAddrData", ArgumentSemantic.Assign)]
		NSData IpAddrData { get; set; }

		// -(id)initWithIsSuc:(BOOL)isSuc andBssid:(NSString *)bssid andInetAddrData:(NSData *)ipAddrData;
		[Export("initWithIsSuc:andBssid:andInetAddrData:")]
		IntPtr Constructor(bool isSuc, string bssid, NSData ipAddrData);
	}

	// @protocol ESPTouchDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface ESPTouchDelegate
	{
		// @required -(void)onEsptouchResultAddedWithResult:(ESPTouchResult *)result;
		[Abstract]
		[Export("onEsptouchResultAddedWithResult:")]
		void OnEsptouchResultAddedWithResult(ESPTouchResult result);
	}

	// @interface ESPTouchGenerator : NSObject
	[BaseType(typeof(NSObject))]
	interface ESPTouchGenerator
	{
		// -(id)initWithSsid:(NSString *)apSsid andApBssid:(NSString *)apBssid andApPassword:(NSString *)apPwd andInetAddrData:(NSData *)ipAddrData andIsSsidHidden:(BOOL)isSsidHidden;
		[Export("initWithSsid:andApBssid:andApPassword:andInetAddrData:andIsSsidHidden:")]
		IntPtr Constructor(string apSsid, string apBssid, string apPwd, NSData ipAddrData, bool isSsidHidden);

		// -(NSArray *)getGCBytes2;
		[Export("getGCBytes2")]
		NSObject[] GCBytes2 { get; }

		// -(NSArray *)getDCBytes2;
		[Export("getDCBytes2")]
		NSObject[] DCBytes2 { get; }
	}

	// @interface ESPTouchTask : NSObject
	[BaseType(typeof(NSObject))]
	interface ESPTouchTask
	{
		// @property (assign, atomic) BOOL isCancelled;
		[Export("isCancelled")]
		bool IsCancelled { get; set; }

		// -(id)initWithApSsid:(NSString *)apSsid andApBssid:(NSString *)apBssid andApPwd:(NSString *)apPwd;
		[Export("initWithApSsid:andApBssid:andApPwd:")]
		IntPtr Constructor(string apSsid, string apBssid, string apPwd);

		// -(id)initWithApSsid:(NSString *)apSsid andApBssid:(NSString *)apBssid andApPwd:(NSString *)apPwd andIsSsidHiden:(BOOL)isSsidHidden __attribute__((deprecated("Use initWithApSsid:(NSString *) andApBssid:(NSString *) andApPwd:(NSString *) instead.")));
		[Export("initWithApSsid:andApBssid:andApPwd:andIsSsidHiden:")]
		IntPtr Constructor(string apSsid, string apBssid, string apPwd, bool isSsidHidden);

		// -(id)initWithApSsid:(NSString *)apSsid andApBssid:(NSString *)apBssid andApPwd:(NSString *)apPwd andTimeoutMillisecond:(int)timeoutMillisecond;
		[Export("initWithApSsid:andApBssid:andApPwd:andTimeoutMillisecond:")]
		IntPtr Constructor(string apSsid, string apBssid, string apPwd, int timeoutMillisecond);

		// -(id)initWithApSsid:(NSString *)apSsid andApBssid:(NSString *)apBssid andApPwd:(NSString *)apPwd andIsSsidHiden:(BOOL)isSsidHidden andTimeoutMillisecond:(int)timeoutMillisecond __attribute__((deprecated("Use initWithApSsid:(NSString *) andApBssid:(NSString *) andApPwd:(NSString *) andTimeoutMillisecond:(int) instead.")));
		[Export("initWithApSsid:andApBssid:andApPwd:andIsSsidHiden:andTimeoutMillisecond:")]
		IntPtr Constructor(string apSsid, string apBssid, string apPwd, bool isSsidHidden, int timeoutMillisecond);

		// -(void)interrupt;
		[Export("interrupt")]
		void Interrupt();

		// -(ESPTouchResult *)executeForResult;
		[Export("executeForResult")]
		ESPTouchResult ExecuteForResult { get; }

		// -(NSArray *)executeForResults:(int)expectTaskResultCount;
		[Export("executeForResults:")]
		NSObject[] ExecuteForResults(int expectTaskResultCount);

		// -(void)setEsptouchDelegate:(NSObject<ESPTouchDelegate> *)esptouchDelegate;
		[Export("setEsptouchDelegate:")]
		void SetEsptouchDelegate(ESPTouchDelegate esptouchDelegate);
	}

	// @interface ESPTaskParameter : NSObject
	[BaseType(typeof(NSObject))]
	interface ESPTaskParameter
	{
		// -(long)getIntervalGuideCodeMillisecond;
		[Export("getIntervalGuideCodeMillisecond")]
		nint IntervalGuideCodeMillisecond { get; }

		// -(long)getIntervalDataCodeMillisecond;
		[Export("getIntervalDataCodeMillisecond")]
		nint IntervalDataCodeMillisecond { get; }

		// -(long)getTimeoutGuideCodeMillisecond;
		[Export("getTimeoutGuideCodeMillisecond")]
		nint TimeoutGuideCodeMillisecond { get; }

		// -(long)getTimeoutDataCodeMillisecond;
		[Export("getTimeoutDataCodeMillisecond")]
		nint TimeoutDataCodeMillisecond { get; }

		// -(long)getTimeoutTotalCodeMillisecond;
		[Export("getTimeoutTotalCodeMillisecond")]
		nint TimeoutTotalCodeMillisecond { get; }

		// -(int)getTotalRepeatTime;
		[Export("getTotalRepeatTime")]
		int TotalRepeatTime { get; }

		// -(int)getEsptouchResultOneLen;
		[Export("getEsptouchResultOneLen")]
		int EsptouchResultOneLen { get; }

		// -(int)getEsptouchResultMacLen;
		[Export("getEsptouchResultMacLen")]
		int EsptouchResultMacLen { get; }

		// -(int)getEsptouchResultIpLen;
		[Export("getEsptouchResultIpLen")]
		int EsptouchResultIpLen { get; }

		// -(int)getEsptouchResultTotalLen;
		[Export("getEsptouchResultTotalLen")]
		int EsptouchResultTotalLen { get; }

		// -(int)getPortListening;
		[Export("getPortListening")]
		int PortListening { get; }

		// -(NSString *)getTargetHostname;
		[Export("getTargetHostname")]
		string TargetHostname { get; }

		// -(int)getTargetPort;
		[Export("getTargetPort")]
		int TargetPort { get; }

		// -(int)getWaitUdpReceivingMillisecond;
		[Export("getWaitUdpReceivingMillisecond")]
		int WaitUdpReceivingMillisecond { get; }

		// -(int)getWaitUdpSendingMillisecond;
		[Export("getWaitUdpSendingMillisecond")]
		int WaitUdpSendingMillisecond { get; }

		// -(int)getWaitUdpTotalMillisecond;
		[Export("getWaitUdpTotalMillisecond")]
		int WaitUdpTotalMillisecond { get; }

		// -(int)getThresholdSucBroadcastCount;
		[Export("getThresholdSucBroadcastCount")]
		int ThresholdSucBroadcastCount { get; }

		// -(void)setWaitUdpTotalMillisecond:(int)waitUdpTotalMillisecond;
		[Export("setWaitUdpTotalMillisecond:")]
		void SetWaitUdpTotalMillisecond(int waitUdpTotalMillisecond);

		// -(int)getExpectTaskResultCount;
		[Export("getExpectTaskResultCount")]
		int ExpectTaskResultCount { get; }

		// -(void)setExpectTaskResultCount:(int)expectTaskResultCount;
		[Export("setExpectTaskResultCount:")]
		void SetExpectTaskResultCount(int expectTaskResultCount);

		// -(BOOL)isIPv4Supported;
		// -(void)setIsIPv4Supported:(BOOL)isIPv4Supported;
		[Export("isIPv4Supported")]
		bool IsIPv4Supported { get; set; }

		// -(BOOL)isIPv6Supported;
		[Export("isIPv6Supported")]
		bool IsIPv6Supported();

		// -(void)setIsIPv6Supported:(BOOL)isIPv6Supported;
		[Export("setIsIPv6Supported:")]
		void SetIsIPv6Supported(bool isIPv6Supported);

		// -(void)setListeningPort6:(int)listeningPort6;
		[Export("setListeningPort6:")]
		void SetListeningPort6(int listeningPort6);
	}

	// @interface ESPUDPSocketClient : NSObject
	[BaseType(typeof(NSObject))]
	interface ESPUDPSocketClient
	{
		// -(void)close;
		[Export("close")]
		void Close();

		// -(void)interrupt;
		[Export("interrupt")]
		void Interrupt();

		// -(void)sendDataWithBytesArray2:(NSArray *)bytesArray2 ToTargetHostName:(NSString *)targetHostName WithPort:(int)port andInterval:(long)interval;
		[Export("sendDataWithBytesArray2:ToTargetHostName:WithPort:andInterval:")]
		void SendDataWithBytesArray2(NSObject[] bytesArray2, string targetHostName, int port, nint interval);

		// -(void)sendDataWithBytesArray2:(NSArray *)bytesArray2 Offset:(NSUInteger)offset Count:(NSUInteger)count ToTargetHostName:(NSString *)targetHostName WithPort:(int)port andInterval:(long)interval;
		[Export("sendDataWithBytesArray2:Offset:Count:ToTargetHostName:WithPort:andInterval:")]
		void SendDataWithBytesArray2(NSObject[] bytesArray2, nuint offset, nuint count, string targetHostName, int port, nint interval);
	}

	// @interface ESPUDPSocketServer : NSObject
	[BaseType(typeof(NSObject))]
	interface ESPUDPSocketServer
	{
		// @property (assign, nonatomic) int port;
		[Export("port")]
		int Port { get; set; }

		// -(void)close;
		[Export("close")]
		void Close();

		// -(void)interrupt;
		[Export("interrupt")]
		void Interrupt();

		// -(void)setSocketTimeout:(int)timeout;
		[Export("setSocketTimeout:")]
		void SetSocketTimeout(int timeout);

		// -(Byte)receiveOneByte4;
		[Export("receiveOneByte4")]
		byte ReceiveOneByte4 { get; }

		// -(NSData *)receiveSpecLenBytes4:(int)len;
		[Export("receiveSpecLenBytes4:")]
		NSData ReceiveSpecLenBytes4(int len);

		// -(Byte)receiveOneByte6;
		[Export("receiveOneByte6")]
		byte ReceiveOneByte6 { get; }

		// -(NSData *)receiveSpecLenBytes6:(int)len;
		[Export("receiveSpecLenBytes6:")]
		NSData ReceiveSpecLenBytes6(int len);

		// -(id)initWithPort:(int)port AndSocketTimeout:(int)socketTimeout;
		[Export("initWithPort:AndSocketTimeout:")]
		IntPtr Constructor(int port, int socketTimeout);
	}

	// @interface ESP_ByteUtil : NSObject
	[BaseType(typeof(NSObject))]
	interface ESP_ByteUtil
	{
		// +(Byte)convertUint8toByte:(char)uint8;
		[Static]
		[Export("convertUint8toByte:")]
		byte ConvertUint8toByte(sbyte uint8);

		// +(UInt8)convertByte2Uint8:(Byte)b;
		[Static]
		[Export("convertByte2Uint8:")]
		byte ConvertByte2Uint8(byte b);

		// +(NSString *)convertByte2HexString:(Byte)b;
		[Static]
		[Export("convertByte2HexString:")]
		string ConvertByte2HexString(byte b);

		// +(NSData *)splitUint8To2Bytes:(UInt8)uint8;
		[Static]
		[Export("splitUint8To2Bytes:")]
		NSData SplitUint8To2Bytes(byte uint8);

		// +(Byte)combine2bytesToOneWithHigh:(Byte)high andLow:(Byte)low;
		[Static]
		[Export("combine2bytesToOneWithHigh:andLow:")]
		byte Combine2bytesToOneWithHigh(byte high, byte low);

		// +(UInt16)combine2bytesToU16WithHigh:(Byte)high andLow:(Byte)low;
		[Static]
		[Export("combine2bytesToU16WithHigh:andLow:")]
		ushort Combine2bytesToU16WithHigh(byte high, byte low);

		// +(Byte)randomByte;
		[Static]
		[Export("randomByte")]
		byte RandomByte { get; }

		// +(NSData *)randomBytes:(UInt8)len;
		[Static]
		[Export("randomBytes:")]
		NSData RandomBytes(byte len);

		// +(NSData *)genSpecBytesWithU16:(UInt16)len;
		[Static]
		[Export("genSpecBytesWithU16:")]
		NSData GenSpecBytesWithU16(ushort len);

		// +(NSData *)genSpecBytesWithU8:(Byte)len;
		[Static]
		[Export("genSpecBytesWithU8:")]
		NSData GenSpecBytesWithU8(byte len);

		// +(NSString *)parseBssid:(Byte *)bssidBytes Offset:(int)offset Count:(int)count;
		[Static]
		[Export("parseBssid:Offset:Count:")]
		string ParseBssid(IntPtr bssidBytes, int offset, int count);

		// +(NSString *)parseBssid:(Byte *)bssidBytes Len:(int)len;
		[Static]
		[Export("parseBssid:Len:")]
		string ParseBssid(IntPtr bssidBytes, int len);

		// +(NSData *)getBytesByNSString:(NSString *)string;
		[Static]
		[Export("getBytesByNSString:")]
		NSData GetBytesByNSString(string @string);

		// +(NSString *)getHexStringByData:(NSData *)data;
		[Static]
		[Export("getHexStringByData:")]
		string GetHexStringByData(NSData data);
	}

	// @interface ESP_CRC8 : NSObject
	[BaseType(typeof(NSObject))]
	interface ESP_CRC8
	{
		// -(long)getValue;
		[Export("getValue")]
		nint Value { get; }

		// -(void)reset;
		[Export("reset")]
		void Reset();

		// -(void)updateWithBuf:(Byte *)buf Off:(int)off Nbytes:(int)nbytes;
		[Export("updateWithBuf:Off:Nbytes:")]
		void UpdateWithBuf(IntPtr buf, int off, int nbytes);

		// -(void)updateWithBuf:(Byte *)buf Nbytes:(int)nbytes;
		[Export("updateWithBuf:Nbytes:")]
		void UpdateWithBuf(IntPtr buf, int nbytes);

		// -(void)updateWithValue:(int)value;
		[Export("updateWithValue:")]
		void UpdateWithValue(int value);
	}

	// @interface ESP_NetUtil : NSObject
	[BaseType(typeof(NSObject))]
	interface ESP_NetUtil
	{
		// +(NSString *)getLocalIPv4;
		[Static]
		[Export("getLocalIPv4")]
		string LocalIPv4 { get; }

		// +(NSString *)getLocalIPv6;
		[Static]
		[Export("getLocalIPv6")]
		string LocalIPv6 { get; }

		// +(BOOL)isIPv4Addr:(NSString *)ipAddr;
		[Static]
		[Export("isIPv4Addr:")]
		bool IsIPv4Addr(string ipAddr);

		// +(BOOL)isIPv4PrivateAddr:(NSString *)ipAddr;
		[Static]
		[Export("isIPv4PrivateAddr:")]
		bool IsIPv4PrivateAddr(string ipAddr);

		// +(NSData *)getLocalInetAddress4ByAddr:(NSString *)localInetAddr4;
		[Static]
		[Export("getLocalInetAddress4ByAddr:")]
		NSData GetLocalInetAddress4ByAddr(string localInetAddr4);

		// +(NSData *)getLocalInetAddress6ByPort:(int)localPort;
		[Static]
		[Export("getLocalInetAddress6ByPort:")]
		NSData GetLocalInetAddress6ByPort(int localPort);

		// +(NSData *)parseInetAddrByData:(NSData *)inetAddrData andOffset:(int)offset andCount:(int)count;
		[Static]
		[Export("parseInetAddrByData:andOffset:andCount:")]
		NSData ParseInetAddrByData(NSData inetAddrData, int offset, int count);

		// +(NSString *)descriptionInetAddr4ByData:(NSData *)inetAddrData;
		[Static]
		[Export("descriptionInetAddr4ByData:")]
		string DescriptionInetAddr4ByData(NSData inetAddrData);

		// +(NSString *)descriptionInetAddr6ByData:(NSData *)inetAddrData;
		[Static]
		[Export("descriptionInetAddr6ByData:")]
		string DescriptionInetAddr6ByData(NSData inetAddrData);

		// +(NSData *)parseBssid2bytes:(NSString *)bssid;
		[Static]
		[Export("parseBssid2bytes:")]
		NSData ParseBssid2bytes(string bssid);

		// +(void)tryOpenNetworkPermission;
		[Static]
		[Export("tryOpenNetworkPermission")]
		void TryOpenNetworkPermission();
	}

	// @interface ESP_WifiUtil : NSObject
	[BaseType(typeof(NSObject))]
	interface ESP_WifiUtil
	{
		// +(NSString *)getIPAddress:(BOOL)preferIPv4;
		[Static]
		[Export("getIPAddress:")]
		string GetIPAddress(bool preferIPv4);

		// +(NSDictionary *)getIPAddresses;
		[Static]
		[Export("getIPAddresses")]
		NSDictionary IPAddresses { get; }

		// +(NSString *)getIPAddress4;
		[Static]
		[Export("getIPAddress4")]
		string IPAddress4 { get; }

		// +(NSString *)getIpAddress6;
		[Static]
		[Export("getIpAddress6")]
		string IpAddress6 { get; }
	}

	// @interface EspTouch : NSObject
	[BaseType(typeof(NSObject))]
	interface EspTouch
	{
	}
}
