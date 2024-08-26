using System;
using System.Runtime.InteropServices;
using CoreGraphics;
using CoreLocation;
using Foundation;
using ObjCRuntime;
//using SASCollector;
using UIKit;
using WebKit;

namespace Com.SAS.CI360
{
    // @interface SASIA_AdRequest : NSObject
    [BaseType(typeof(NSObject))]
    interface SASIA_AdRequest
    {
        // @property (readonly, nonatomic) NSURL * baseURL;
        [Export("baseURL")]
        NSUrl BaseURL { get; }

        // +(NSString *)domain;
        // +(void)setDomain:(NSString *)domain;
        [Static]
        [Export("domain")]
        //[Verify(MethodToProperty)]
        string Domain { get; set; }

        // +(NSString *)customerId;
        // +(void)setCustomerId:(NSString *)customerId;
        [Static]
        [Export("customerId")]
        //[Verify(MethodToProperty)]
        string CustomerId { get; set; }

        // -(id)initWithTags:(NSDictionary *)tags;
        [Export("initWithTags:")]
        IntPtr Constructor(NSDictionary tags);

        // -(id)initWithURL:(NSString *)url tags:(NSDictionary *)tags;
        [Export("initWithURL:tags:")]
        IntPtr Constructor(string url, NSDictionary tags);

        // -(id)initWithURL:(NSString *)urlString;
        [Export("initWithURL:")]
        IntPtr Constructor(string urlString);

        // -(id)initWithDomain:(NSString *)domain customerId:(NSString *)customerId tags:(NSDictionary *)tags __attribute__((deprecated("Use the static setDomain: and setCustomerId: methods instead.")));
        [Export("initWithDomain:customerId:tags:")]
        IntPtr Constructor(string domain, string customerId, NSDictionary tags);
    }

    // @protocol SASIA_MRAIDWebViewDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface SASIA_MRAIDWebViewDelegate
    {
        // @optional -(void)didLoad:(SASIA_MRAIDWebView * _Nonnull)mraidView;
        [Export("didLoad:")]
        void DidLoad(SASIA_MRAIDWebView mraidView);

        // @optional -(void)didFailLoad:(SASIA_MRAIDWebView * _Nonnull)mraidView error:(NSError * _Nonnull)error failingUrl:(NSString * _Nullable)url;
        [Export("didFailLoad:error:failingUrl:")]
        void DidFailLoad(SASIA_MRAIDWebView mraidView, NSError error, [NullAllowed] string url);

        // @optional -(BOOL)willClose:(SASIA_MRAIDWebView * _Nonnull)mraidView;
        [Export("willClose:")]
        bool WillClose(SASIA_MRAIDWebView mraidView);

        // @optional -(void)didClose:(SASIA_MRAIDWebView * _Nonnull)mraidView;
        [Export("didClose:")]
        void DidClose(SASIA_MRAIDWebView mraidView);

        // @optional -(BOOL)willBeginAction:(SASIA_MRAIDWebView * _Nonnull)mraidView url:(NSString * _Nonnull)url;
        [Export("willBeginAction:url:")]
        bool WillBeginAction(SASIA_MRAIDWebView mraidView, string url);

        // @optional -(void)didFinishAction:(SASIA_MRAIDWebView * _Nonnull)mraidView;
        [Export("didFinishAction:")]
        void DidFinishAction(SASIA_MRAIDWebView mraidView);

        // @optional -(BOOL)willExpand:(SASIA_MRAIDWebView * _Nonnull)mraidView url:(NSString * _Nonnull)url;
        [Export("willExpand:url:")]
        bool WillExpand(SASIA_MRAIDWebView mraidView, string url);

        // @optional -(void)didFinishExpand:(SASIA_MRAIDWebView * _Nonnull)mraidView;
        [Export("didFinishExpand:")]
        void DidFinishExpand(SASIA_MRAIDWebView mraidView);

        // @optional -(BOOL)willResize:(SASIA_MRAIDWebView * _Nonnull)mraidView size:(CGRect)size;
        [Export("willResize:size:")]
        bool WillResize(SASIA_MRAIDWebView mraidView, CGRect size);

        // @optional -(void)didFinishResize:(SASIA_MRAIDWebView * _Nonnull)mraidView;
        [Export("didFinishResize:")]
        void DidFinishResize(SASIA_MRAIDWebView mraidView);
    }

    // @interface SASIA_MRAIDWebView : UIView <WKScriptMessageHandler>
    [BaseType(typeof(UIView))]
    interface SASIA_MRAIDWebView : IWKScriptMessageHandler
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        SASIA_MRAIDWebViewDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<SASIA_MRAIDWebViewDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic, weak) UIViewController * _Nullable hostViewController;
        [NullAllowed, Export("hostViewController", ArgumentSemantic.Weak)]
        UIViewController HostViewController { get; set; }

        // @property (readonly, nonatomic) UIViewController * _Nullable viewController;
        [NullAllowed, Export("viewController")]
        UIViewController ViewController { get; }

        // @property (readonly, atomic) WKWebView * _Nonnull webView;
        [Export("webView")]
        WKWebView WebView { get; }

        // @property (assign, nonatomic) BOOL isInterstitial;
        [Export("isInterstitial")]
        bool IsInterstitial { get; set; }

        // @property (assign, nonatomic) UIModalTransitionStyle interstitialTransitionStyle;
        [Export("interstitialTransitionStyle", ArgumentSemantic.Assign)]
        UIModalTransitionStyle InterstitialTransitionStyle { get; set; }

        // @property (assign, nonatomic) BOOL visible;
        [Export("visible")]
        bool Visible { get; set; }

        // @property (getter = isActionInBrowser, assign, nonatomic) BOOL actionInBrowser;
        [Export("actionInBrowser")]
        bool ActionInBrowser { [Bind("isActionInBrowser")] get; set; }

        // @property (assign, nonatomic) UIModalTransitionStyle actionTransitionStyle;
        [Export("actionTransitionStyle", ArgumentSemantic.Assign)]
        UIModalTransitionStyle ActionTransitionStyle { get; set; }

        // @property (assign, nonatomic) UIModalPresentationStyle modalPresentationStyle;
        [Export("modalPresentationStyle", ArgumentSemantic.Assign)]
        UIModalPresentationStyle ModalPresentationStyle { get; set; }

        // @property (readonly, getter = isActionInProgress, nonatomic) BOOL actionInProgress;
        [Export("actionInProgress")]
        bool ActionInProgress { [Bind("isActionInProgress")] get; }

        // @property (readonly, nonatomic) UIViewController * _Nullable actionViewController;
        [NullAllowed, Export("actionViewController")]
        UIViewController ActionViewController { get; }

        // -(void)showInterstitially:(UIViewController * _Nonnull)hostController strongReference:(NSObject * _Nonnull)strongReference;
        [Export("showInterstitially:strongReference:")]
        void ShowInterstitially(UIViewController hostController, NSObject strongReference);

        // -(void)load:(NSURL * _Nonnull)url;
        [Export("load:")]
        void Load(NSUrl url);

        // -(void)close;
        [Export("close")]
        void Close();

        // -(void)cancelAction;
        [Export("cancelAction")]
        void CancelAction();

        // -(void)executeJavaScript:(NSString * _Nullable)js jsStringExpression:(NSString * _Nullable)jsStringExpression completionHandler:(void (^ _Nullable)(id _Nullable, NSError * _Nullable))completion;
        [Export("executeJavaScript:jsStringExpression:completionHandler:")]
        void ExecuteJavaScript([NullAllowed] string js, [NullAllowed] string jsStringExpression, [NullAllowed] Action<NSObject, NSError> completion);

        // -(void)htmlContent:(void (^ _Nullable)(id _Nullable, NSError * _Nullable))completion;
        [Export("htmlContent:")]
        void HtmlContent([NullAllowed] Action<NSObject, NSError> completion);

        // -(void)didChangeVisibility:(BOOL)newVisible;
        [Export("didChangeVisibility:")]
        void DidChangeVisibility(bool newVisible);

        // -(void)allowContentCaching:(BOOL)allowCache;
        [Export("allowContentCaching:")]
        void AllowContentCaching(bool allowCache);

        // +(BOOL)mraidTracing;
        // +(void)setMraidTracing:(BOOL)trace;
        [Static]
        [Export("mraidTracing")]
        //[Verify(MethodToProperty)]
        bool MraidTracing { get; set; }

        // +(void)supportSMSText:(BOOL)support;
        [Static]
        [Export("supportSMSText:")]
        void SupportSMSText(bool support);

        // +(BOOL)supportsSMSText;
        [Static]
        [Export("supportsSMSText")]
        //[Verify(MethodToProperty)]
        bool SupportsSMSText { get; }

        // +(void)supportTelephone:(BOOL)support;
        [Static]
        [Export("supportTelephone:")]
        void SupportTelephone(bool support);

        // +(BOOL)supportsTelephone;
        [Static]
        [Export("supportsTelephone")]
        //[Verify(MethodToProperty)]
        bool SupportsTelephone { get; }

        // +(void)supportPicture:(BOOL)support;
        [Static]
        [Export("supportPicture:")]
        void SupportPicture(bool support);

        // +(BOOL)supportsPicture;
        [Static]
        [Export("supportsPicture")]
        //[Verify(MethodToProperty)]
        bool SupportsPicture { get; }

        // +(void)supportCalendar:(BOOL)support;
        [Static]
        [Export("supportCalendar:")]
        void SupportCalendar(bool support);

        // +(BOOL)supportsCalendar;
        [Static]
        [Export("supportsCalendar")]
        //[Verify(MethodToProperty)]
        bool SupportsCalendar { get; }
    }

    // @protocol SASIA_AdDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface SASIA_AdDelegate
    {
        // @optional -(void)didLoad:(SASIA_AbstractAd * _Nonnull)ad;
        [Export("didLoad:")]
        void DidLoad(SASIA_AbstractAd ad);

        // @optional -(void)didLoadDefault:(SASIA_AbstractAd * _Nonnull)ad;
        [Export("didLoadDefault:")]
        void DidLoadDefault(SASIA_AbstractAd ad);

        // @optional -(void)didFailLoad:(SASIA_AbstractAd * _Nonnull)ad error:(NSError * _Nonnull)error failingUrl:(NSString * _Nullable)failingUrl;
        [Export("didFailLoad:error:failingUrl:")]
        void DidFailLoad(SASIA_AbstractAd ad, NSError error, [NullAllowed] string failingUrl);

        // @optional -(BOOL)willClose:(SASIA_AbstractAd * _Nonnull)ad;
        [Export("willClose:")]
        bool WillClose(SASIA_AbstractAd ad);

        // @optional -(void)didClose:(SASIA_AbstractAd * _Nonnull)ad;
        [Export("didClose:")]
        void DidClose(SASIA_AbstractAd ad);

        // @optional -(BOOL)willBeginAction:(SASIA_AbstractAd * _Nonnull)ad url:(NSString * _Nonnull)url;
        [Export("willBeginAction:url:")]
        bool WillBeginAction(SASIA_AbstractAd ad, string url);

        // @optional -(void)didFinishAction:(SASIA_AbstractAd * _Nonnull)ad;
        [Export("didFinishAction:")]
        void DidFinishAction(SASIA_AbstractAd ad);

        // @optional -(BOOL)willExpand:(SASIA_AbstractAd * _Nonnull)ad url:(NSString * _Nonnull)url;
        [Export("willExpand:url:")]
        bool WillExpand(SASIA_AbstractAd ad, string url);

        // @optional -(void)didFinishExpand:(SASIA_AbstractAd * _Nonnull)ad;
        [Export("didFinishExpand:")]
        void DidFinishExpand(SASIA_AbstractAd ad);

        // @optional -(BOOL)willResize:(SASIA_AbstractAd * _Nonnull)ad size:(CGRect)size;
        [Export("willResize:size:")]
        bool WillResize(SASIA_AbstractAd ad, CGRect size);

        // @optional -(void)didFinishResize:(SASIA_AbstractAd * _Nonnull)ad;
        [Export("didFinishResize:")]
        void DidFinishResize(SASIA_AbstractAd ad);

        // @optional -(NSString * _Nonnull)description;
        [Export("description")]
        //[Verify(MethodToProperty)]
        string Description { get; }
    }

    // @interface SASIA_AbstractAd : UIView <SASIA_MRAIDWebViewDelegate>
    [BaseType(typeof(UIView))]
    interface SASIA_AbstractAd : SASIA_MRAIDWebViewDelegate
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        SASIA_AdDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<SASIA_AdDelegate> _Nullable delegate __attribute__((iboutlet));
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (assign, nonatomic) UIViewController * _Nullable hostViewController __attribute__((iboutlet));
        [NullAllowed, Export("hostViewController", ArgumentSemantic.Assign)]
        UIViewController HostViewController { get; set; }

        // @property (readonly, nonatomic) UIViewController * _Nonnull viewController;
        [Export("viewController")]
        UIViewController ViewController { get; }

        // @property (readonly, nonatomic) WKWebView * _Nonnull webView;
        [Export("webView")]
        WKWebView WebView { get; }

        // @property (readonly, nonatomic) NSInteger fcid;
        [Export("fcid")]
        nint Fcid { get; }

        // @property (readonly, getter = isLoaded, nonatomic) BOOL loaded;
        [Export("loaded")]
        bool Loaded { [Bind("isLoaded")] get; }

        // @property (readonly, getter = isDefaultLoaded, nonatomic) BOOL defaultLoaded;
        [Export("defaultLoaded")]
        bool DefaultLoaded { [Bind("isDefaultLoaded")] get; }

        // @property (readonly, nonatomic) UIViewController * _Nullable actionViewController;
        [NullAllowed, Export("actionViewController")]
        UIViewController ActionViewController { get; }

        // @property (getter = isActionInBrowser, assign, nonatomic) BOOL actionInBrowser;
        [Export("actionInBrowser")]
        bool ActionInBrowser { [Bind("isActionInBrowser")] get; set; }

        // @property (assign, nonatomic) UIModalTransitionStyle actionTransitionStyle;
        [Export("actionTransitionStyle", ArgumentSemantic.Assign)]
        UIModalTransitionStyle ActionTransitionStyle { get; set; }

        // @property (assign, nonatomic) UIModalPresentationStyle modalPresentationStyle;
        [Export("modalPresentationStyle", ArgumentSemantic.Assign)]
        UIModalPresentationStyle ModalPresentationStyle { get; set; }

        // @property (readonly, getter = isActionInProgress, nonatomic) BOOL actionInProgress;
        [Export("actionInProgress")]
        bool ActionInProgress { [Bind("isActionInProgress")] get; }

        // -(void)load:(SASIA_AdRequest * _Nonnull)adRequest;
        [Export("load:")]
        void Load(SASIA_AdRequest adRequest);

        // -(void)close;
        [Export("close")]
        void Close();

        // -(void)cancelAction;
        [Export("cancelAction")]
        void CancelAction();

        // -(void)executeJavaScript:(NSString * _Nullable)js jsStringExpression:(NSString * _Nullable)jsStringExpression completionHandler:(void (^ _Nullable)(id _Nullable, NSError * _Nullable))completionHandler;
        [Export("executeJavaScript:jsStringExpression:completionHandler:")]
        void ExecuteJavaScript([NullAllowed] string js, [NullAllowed] string jsStringExpression, [NullAllowed] Action<NSObject, NSError> completionHandler);

        // -(void)didChangeVisibility:(BOOL)newVisible;
        [Export("didChangeVisibility:")]
        void DidChangeVisibility(bool newVisible);

        // -(BOOL)isInterstitial;
        [Export("isInterstitial")]
        //[Verify(MethodToProperty)]
        bool IsInterstitial { get; }

        // -(void)allowContentCaching:(BOOL)allowCache;
        [Export("allowContentCaching:")]
        void AllowContentCaching(bool allowCache);
    }

    // @interface SASIA_Ad : SASIA_AbstractAd
    [BaseType(typeof(SASIA_AbstractAd))]
    interface SASIA_Ad
    {
        // @property (readonly, atomic) UIView * view;
        [Export("view")]
        UIView View { get; }

        // -(id)initForController:(UIViewController *)hostViewController withFrame:(CGRect)frame;
        [Export("initForController:withFrame:")]
        IntPtr Constructor(UIViewController hostViewController, CGRect frame);
    }

    // @interface SASCollectorUIAdView : SASIA_Ad
    [BaseType(typeof(SASIA_Ad))]
    interface SASCollectorUIAdView
    {
        // @property (nonatomic, strong) NSString * spotID;
        [Export("spotID", ArgumentSemantic.Strong)]
        string SpotID { get; set; }

        // @property (readonly, nonatomic, strong) SASIA_AdRequest * adRequest;
        [Export("adRequest", ArgumentSemantic.Strong)]
        SASIA_AdRequest AdRequest { get; }

        // -(id)initForController:(UIViewController *)hostViewController withFrame:(CGRect)frame withSpotId:(NSString *)spotid withTags:(NSDictionary *)attributes;
        [Export("initForController:withFrame:withSpotId:withTags:")]
        IntPtr Constructor(UIViewController hostViewController, CGRect frame, string spotid, NSDictionary attributes);

        // -(void)load;
        [Export("load")]
        void Load();

        // -(void)setSpotAttributes:(NSDictionary *)attributes;
        [Export("setSpotAttributes:")]
        void SetSpotAttributes(NSDictionary attributes);

        // -(void)addSpotAttributeName:(NSString *)name value:(NSString *)value;
        [Export("addSpotAttributeName:value:")]
        void AddSpotAttributeName(string name, string value);

        // -(void)removeSpotAttribute:(NSString *)name;
        [Export("removeSpotAttribute:")]
        void RemoveSpotAttribute(string name);
    }

    // @interface SASIA_InterstitialAd : SASIA_AbstractAd
    [BaseType(typeof(SASIA_AbstractAd))]
    interface SASIA_InterstitialAd
    {
        // @property (assign, nonatomic) UIModalTransitionStyle interstitialTransitionStyle;
        [Export("interstitialTransitionStyle", ArgumentSemantic.Assign)]
        UIModalTransitionStyle InterstitialTransitionStyle { get; set; }

        // -(void)showFromController:(UIViewController *)hostController;
        [Export("showFromController:")]
        void ShowFromController(UIViewController hostController);
    }

    // @interface SASCollectorInterstitialAd : SASIA_InterstitialAd
    [BaseType(typeof(SASIA_InterstitialAd))]
    interface SASCollectorInterstitialAd
    {
        // @property (nonatomic, strong) NSString * spotID;
        [Export("spotID", ArgumentSemantic.Strong)]
        string SpotID { get; set; }

        // @property (readonly, nonatomic, strong) SASIA_AdRequest * adRequest;
        [Export("adRequest", ArgumentSemantic.Strong)]
        SASIA_AdRequest AdRequest { get; }

        // -(id)initWithSpotId:(NSString *)spotid withTags:(NSDictionary *)attributes;
        [Export("initWithSpotId:withTags:")]
        IntPtr Constructor(string spotid, NSDictionary attributes);

        // -(void)load;
        [Export("load")]
        void Load();

        // -(void)setSpotAttributes:(NSDictionary *)attributes;
        [Export("setSpotAttributes:")]
        void SetSpotAttributes(NSDictionary attributes);

        // -(void)addSpotAttributeName:(NSString *)name value:(NSString *)value;
        [Export("addSpotAttributeName:value:")]
        void AddSpotAttributeName(string name, string value);

        // -(void)removeSpotAttribute:(NSString *)name;
        [Export("removeSpotAttribute:")]
        void RemoveSpotAttribute(string name);
    }

    // @interface SASCollectorViewController : UIViewController
    [BaseType(typeof(UIViewController))]
    interface SASCollectorViewController
    {
        // @property (nonatomic, strong) NSString * cisdkPageName;
        [Export("cisdkPageName", ArgumentSemantic.Strong)]
        string CisdkPageName { get; set; }
    }

    [Static]
    //[Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const SASCOLLECTOR_ADCLICKED;
        [Field("SASCOLLECTOR_ADCLICKED", "__Internal")]
        NSString SASCOLLECTOR_ADCLICKED { get; }

        // extern NSString *const SASCOLLECTOR_ADCLOSED;
        [Field("SASCOLLECTOR_ADCLOSED", "__Internal")]
        NSString SASCOLLECTOR_ADCLOSED { get; }

        // extern NSString *const SASCOLLECTOR_ADDEFAULT;
        [Field("SASCOLLECTOR_ADDEFAULT", "__Internal")]
        NSString SASCOLLECTOR_ADDEFAULT { get; }

        // extern NSString *const SASCOLLECTOR_ADFAIL;
        [Field("SASCOLLECTOR_ADFAIL", "__Internal")]
        NSString SASCOLLECTOR_ADFAIL { get; }

        // extern NSString *const SASCOLLECTOR_ADRECEIVED;
        [Field("SASCOLLECTOR_ADRECEIVED", "__Internal")]
        NSString SASCOLLECTOR_ADRECEIVED { get; }

        // extern NSString *const SASCOLLECTOR_ADREQUEST;
        [Field("SASCOLLECTOR_ADREQUEST", "__Internal")]
        NSString SASCOLLECTOR_ADREQUEST { get; }

        // extern NSString *const SASCOLLECTOR_ADVISIBLE;
        [Field("SASCOLLECTOR_ADVISIBLE", "__Internal")]
        NSString SASCOLLECTOR_ADVISIBLE { get; }

        // extern NSString *const SASCOLLECTOR_COOKIE_NAME;
        [Field("SASCOLLECTOR_COOKIE_NAME", "__Internal")]
        NSString SASCOLLECTOR_COOKIE_NAME { get; }

        // extern NSString *const SASCOLLECTOR_DEFOCUS;
        [Field("SASCOLLECTOR_DEFOCUS", "__Internal")]
        NSString SASCOLLECTOR_DEFOCUS { get; }

        // extern NSString *const SASCOLLECTOR_ENTERBEACON;
        [Field("SASCOLLECTOR_ENTERBEACON", "__Internal")]
        NSString SASCOLLECTOR_ENTERBEACON { get; }

        // extern NSString *const SASCOLLECTOR_ENTERREGION;
        [Field("SASCOLLECTOR_ENTERREGION", "__Internal")]
        NSString SASCOLLECTOR_ENTERREGION { get; }

        // extern NSString *const SASCOLLECTOR_EXITREGION;
        [Field("SASCOLLECTOR_EXITREGION", "__Internal")]
        NSString SASCOLLECTOR_EXITREGION { get; }

        // extern NSString *const SASCOLLECTOR_FOCUS;
        [Field("SASCOLLECTOR_FOCUS", "__Internal")]
        NSString SASCOLLECTOR_FOCUS { get; }

        // extern NSString *const SASCOLLECTOR_IDENTITY;
        [Field("SASCOLLECTOR_IDENTITY", "__Internal")]
        NSString SASCOLLECTOR_IDENTITY { get; }

        // extern NSString *const SASCOLLECTOR_IDENTITY_TYPE_CUSTOMER_ID;
        [Field("SASCOLLECTOR_IDENTITY_TYPE_CUSTOMER_ID", "__Internal")]
        NSString SASCOLLECTOR_IDENTITY_TYPE_CUSTOMER_ID { get; }

        // extern NSString *const SASCOLLECTOR_IDENTITY_TYPE_EMAIL;
        [Field("SASCOLLECTOR_IDENTITY_TYPE_EMAIL", "__Internal")]
        NSString SASCOLLECTOR_IDENTITY_TYPE_EMAIL { get; }

        // extern NSString *const SASCOLLECTOR_IDENTITY_TYPE_LOGIN;
        [Field("SASCOLLECTOR_IDENTITY_TYPE_LOGIN", "__Internal")]
        NSString SASCOLLECTOR_IDENTITY_TYPE_LOGIN { get; }

        // extern NSString *const SASCOLLECTOR_LOAD;
        [Field("SASCOLLECTOR_LOAD", "__Internal")]
        NSString SASCOLLECTOR_LOAD { get; }

        // extern NSString *const SASCOLLECTOR_MESSAGE_DISMISS;
        [Field("SASCOLLECTOR_MESSAGE_DISMISS", "__Internal")]
        NSString SASCOLLECTOR_MESSAGE_DISMISS { get; }

        // extern NSString *const SASCOLLECTOR_SHUTDOWN;
        [Field("SASCOLLECTOR_SHUTDOWN", "__Internal")]
        NSString SASCOLLECTOR_SHUTDOWN { get; }

        // extern NSString *const SASCOLLECTOR_UNKNOWNLOCATION;
        [Field("SASCOLLECTOR_UNKNOWNLOCATION", "__Internal")]
        NSString SASCOLLECTOR_UNKNOWNLOCATION { get; }

        // extern NSString *const SASCOLLECTOR_VID_COOKIE_NAME;
        [Field("SASCOLLECTOR_VID_COOKIE_NAME", "__Internal")]
        NSString SASCOLLECTOR_VID_COOKIE_NAME { get; }

        // extern NSString *const SASNOTIFICATION_APPLICATION_DISABLED;
        [Field("SASNOTIFICATION_APPLICATION_DISABLED", "__Internal")]
        NSString SASNOTIFICATION_APPLICATION_DISABLED { get; }

        // extern NSString *const SASNOTIFICATION_APPLICATION_ENABLED;
        [Field("SASNOTIFICATION_APPLICATION_ENABLED", "__Internal")]
        NSString SASNOTIFICATION_APPLICATION_ENABLED { get; }

        // extern NSString *const SASNOTIFICATION_BEACON_ENTER;
        [Field("SASNOTIFICATION_BEACON_ENTER", "__Internal")]
        NSString SASNOTIFICATION_BEACON_ENTER { get; }

        // extern NSString *const SASNOTIFICATION_EVENT_DELIVERED;
        [Field("SASNOTIFICATION_EVENT_DELIVERED", "__Internal")]
        NSString SASNOTIFICATION_EVENT_DELIVERED { get; }

        // extern NSString *const SASNOTIFICATION_EVENT_FAILED;
        [Field("SASNOTIFICATION_EVENT_FAILED", "__Internal")]
        NSString SASNOTIFICATION_EVENT_FAILED { get; }

        // extern NSString *const SASNOTIFICATION_NETWORK_REACHABILITY;
        [Field("SASNOTIFICATION_NETWORK_REACHABILITY", "__Internal")]
        NSString SASNOTIFICATION_NETWORK_REACHABILITY { get; }

        // extern NSString *const SASNOTIFICATION_REGIONS_ENTER;
        [Field("SASNOTIFICATION_REGIONS_ENTER", "__Internal")]
        NSString SASNOTIFICATION_REGIONS_ENTER { get; }

        // extern NSString *const SASNOTIFICATION_REGIONS_EXIT;
        [Field("SASNOTIFICATION_REGIONS_EXIT", "__Internal")]
        NSString SASNOTIFICATION_REGIONS_EXIT { get; }

        // extern NSString *const SASNOTIFICATION_REGIONS_UPDATE;
        [Field("SASNOTIFICATION_REGIONS_UPDATE", "__Internal")]
        NSString SASNOTIFICATION_REGIONS_UPDATE { get; }

        // extern NSString *const SASNOTIFICATION_USERINFO_BEACON_MAJOR;
        [Field("SASNOTIFICATION_USERINFO_BEACON_MAJOR", "__Internal")]
        NSString SASNOTIFICATION_USERINFO_BEACON_MAJOR { get; }

        // extern NSString *const SASNOTIFICATION_USERINFO_BEACON_MINOR;
        [Field("SASNOTIFICATION_USERINFO_BEACON_MINOR", "__Internal")]
        NSString SASNOTIFICATION_USERINFO_BEACON_MINOR { get; }

        // extern NSString *const SASNOTIFICATION_USERINFO_BEACON_UUID;
        [Field("SASNOTIFICATION_USERINFO_BEACON_UUID", "__Internal")]
        NSString SASNOTIFICATION_USERINFO_BEACON_UUID { get; }

        // extern NSString *const SASNOTIFICATION_USERINFO_EVENT;
        [Field("SASNOTIFICATION_USERINFO_EVENT", "__Internal")]
        NSString SASNOTIFICATION_USERINFO_EVENT { get; }

        // extern NSString *const SASNOTIFICATION_USERINFO_REGION_IDENTIFIER;
        [Field("SASNOTIFICATION_USERINFO_REGION_IDENTIFIER", "__Internal")]
        NSString SASNOTIFICATION_USERINFO_REGION_IDENTIFIER { get; }
    }

    // @protocol SASLoggerFormatter <NSObject>
    /*
      Check whether adding [Model] to this declaration is appropriate.
      [Model] is used to generate a C# class that implements this protocol,
      and might be useful for protocols that consumers are supposed to implement,
      since consumers can subclass the generated class instead of implementing
      the generated interface. If consumers are not supposed to implement this
      protocol, then [Model] is redundant and will generate code that will never
      be used.
    */

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface SASLoggerFormatter
    {
        // @required -(NSString *)formatLevel:(SASLoggerFlag)flag file:(const char *)file function:(const char *)function line:(NSUInteger)line msg:(NSString *)msg;
        [Abstract]
        [Export("formatLevel:file:function:line:msg:")]
        unsafe string FormatLevel(SASLoggerFlag flag, string file, string function, nuint line, string msg);
    }

    // @interface SASLoggerSimpleFormatter : NSObject <SASLoggerFormatter>
    [BaseType(typeof(NSObject))]
    interface SASLoggerSimpleFormatter : SASLoggerFormatter
    {
        // -(NSString *)formatLevel:(SASLoggerFlag)Flag file:(const char *)file function:(const char *)function line:(NSUInteger)line msg:(NSString *)msg;
        [Export("formatLevel:file:function:line:msg:")]
        unsafe string FormatLevel(SASLoggerFlag Flag, string file, string function, nuint line, string msg);
    }

    // @interface SASLoggerFullFormatter : NSObject <SASLoggerFormatter>
    [BaseType(typeof(NSObject))]
    interface SASLoggerFullFormatter : SASLoggerFormatter
    {
        // -(NSString *)formatLevel:(SASLoggerFlag)flag file:(const char *)file function:(const char *)function line:(NSUInteger)line msg:(NSString *)msg;
        [Export("formatLevel:file:function:line:msg:")]
        unsafe string FormatLevel(SASLoggerFlag flag, string file, string function, nuint line, string msg);
    }

    // @interface SASLogger : NSObject
    [BaseType(typeof(NSObject))]
    interface SASLogger
    {
        // +(void)error:(NSString *)msg;
        [Static]
        [Export("error:")]
        void Error(string msg);

        // +(void)warn:(NSString *)msg;
        [Static]
        [Export("warn:")]
        void Warn(string msg);

        // +(void)info:(NSString *)msg;
        [Static]
        [Export("info:")]
        void Info(string msg);

        // +(void)debug:(NSString *)msg;
        [Static]
        [Export("debug:")]
        void Debug(string msg);

        // +(void)verbose:(NSString *)msg;
        [Static]
        [Export("verbose:")]
        void Verbose(string msg);

        // +(void)setLevel:(SASLoggerLevel)level;
        [Static]
        [Export("setLevel:")]
        void SetLevel(SASLoggerLevel level);

        // +(void)logLevel:(SASLoggerFlag)level file:(const char *)file function:(const char *)function line:(NSUInteger)line format:(NSString *)format, ...;
        [Static, Internal]
        [Export("logLevel:file:function:line:format:", IsVariadic = true)]
        unsafe void LogLevel(SASLoggerFlag level, string file, string function, nuint line, string format, IntPtr varArgs);

        // +(void)setFormatter:(id<SASLoggerFormatter>)formatter;
        [Static]
        [Export("setFormatter:")]
        void SetFormatter(SASLoggerFormatter formatter);

    }

    // @protocol SASCollector_AdDelegate <SASIA_AdDelegate>
    [Protocol, Model]
    interface SASCollector_AdDelegate : SASIA_AdDelegate
    {
    }

    [Static]
    //[Verify(ConstantsInterfaceAssociation)]
    partial interface Constants2
    {
        // extern double SASCollectorVersionNumber;
        [Field("SASCollectorVersionNumber", "__Internal")]
        double SASCollectorVersionNumber { get; }

        // extern const unsigned char[] SASCollectorVersionString;
        [Field("SASCollectorVersionString", "__Internal")]
        uint SASCollectorVersionString { get; }
    }

    // @interface SASCollectorEvent : NSObject
    [BaseType(typeof(NSObject))]
    interface SASCollectorEvent
    {
        // @property (nonatomic, strong) NSString * _Nonnull eventKey;
        [Export("eventKey", ArgumentSemantic.Strong)]
        string EventKey { get; set; }

        // @property (nonatomic, strong) NSDictionary * _Nullable attributes;
        [NullAllowed, Export("attributes", ArgumentSemantic.Strong)]
        NSDictionary Attributes { get; set; }

        // @property (readonly, nonatomic) NSArray * _Nullable cartItems;
        [NullAllowed, Export("cartItems")]
        //[Verify(StronglyTypedNSArray)]
        NSObject[] CartItems { get; }

        // -(instancetype _Nonnull)initWithKey:(NSString * _Nonnull)eventKey attributes:(NSDictionary * _Nullable)attributes;
        [Export("initWithKey:attributes:")]
        IntPtr Constructor(string eventKey, [NullAllowed] NSDictionary attributes);

        // -(instancetype _Nonnull)initWithKey:(NSString * _Nonnull)eventKey;
        [Export("initWithKey:")]
        IntPtr Constructor(string eventKey);

        // -(void)addAttributeWithName:(NSString * _Nonnull)name value:(NSString * _Nonnull)value;
        [Export("addAttributeWithName:value:")]
        void AddAttributeWithName(string name, string value);

        // -(void)removeAttributeWithName:(NSString * _Nonnull)name;
        [Export("removeAttributeWithName:")]
        void RemoveAttributeWithName(string name);

        // -(void)clearAttributes;
        [Export("clearAttributes")]
        void ClearAttributes();

        // -(NSInteger)addCartItem:(NSDictionary * _Nonnull)cartItem;
        [Export("addCartItem:")]
        nint AddCartItem(NSDictionary cartItem);

        // -(void)removeCartItem:(NSInteger)index;
        [Export("removeCartItem:")]
        void RemoveCartItem(nint index);

        // -(void)clearCartItems;
        [Export("clearCartItems")]
        void ClearCartItems();
    }

    // @protocol SASMobileMessagingDelegate2 <NSObject>
    /*
      Check whether adding [Model] to this declaration is appropriate.
      [Model] is used to generate a C# class that implements this protocol,
      and might be useful for protocols that consumers are supposed to implement,
      since consumers can subclass the generated class instead of implementing
      the generated interface. If consumers are not supposed to implement this
      protocol, then [Model] is redundant and will generate code that will never
      be used.
    */
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface SASMobileMessagingDelegate2
    {
        // @required -(void)messageDismissed;
        [Abstract]
        [Export("messageDismissed")]
        void MessageDismissed();

        // @required -(void)actionWithLink:(NSString * _Nonnull)link type:(SASMobileMessageType)type;
        [Abstract]
        [Export("actionWithLink:type:")]
        void ActionWithLink(string link, SASMobileMessageType type);
    }

    // @interface SASCollector : NSObject <CLLocationManagerDelegate>
    [BaseType(typeof(NSObject))]
    //[DisableDefaultCtor]
    interface SASCollector : ICLLocationManagerDelegate
    {
        // +(void)setMobileMessagingDelegate2:(id<SASMobileMessagingDelegate2> _Nullable)delegate;
        [Static]
        [Export("setMobileMessagingDelegate2:")]
        void SetMobileMessagingDelegate2([NullAllowed] SASMobileMessagingDelegate2 @delegate);

        // +(void)setDeveloperInitialized;
        [Static]
        [Export("setDeveloperInitialized")]
        void SetDeveloperInitialized();

        // +(void)initializeCollection;
        [Static]
        [Export("initializeCollection")]
        void InitializeCollection();

        // +(NSString * _Nullable)appId;
        // +(void)setAppId:(NSString * _Nullable)appId;
        [Static]
        [NullAllowed, Export("appId")]
        //[Verify(MethodToProperty)]
        string AppId { get; set; }

        // +(NSString * _Nullable)tenantId;
        // +(void)setTenantId:(NSString * _Nullable)tenantId;
        [Static]
        [NullAllowed, Export("tenantId")]
        //[Verify(MethodToProperty)]
        string TenantId { get; set; }

        // +(NSString * _Nullable)tagServer;
        // +(void)setTagServer:(NSString * _Nullable)tagServer;
        [Static]
        [NullAllowed, Export("tagServer")]
        //[Verify(MethodToProperty)]
        string TagServer { get; set; }

        // +(void)disableLocationMonitoring;
        [Static]
        [Export("disableLocationMonitoring")]
        void DisableLocationMonitoring();

        // +(void)startMonitoringLocation;
        [Static]
        [Export("startMonitoringLocation")]
        void StartMonitoringLocation();

        // +(void)shutdown;
        [Static]
        [Export("shutdown")]
        void Shutdown();

        // +(void)shutdownAndDetachIdentity:(void (^ _Nonnull)(_Bool))completionHandler;
        [Static]
        [Export("shutdownAndDetachIdentity:")]
        void ShutdownAndDetachIdentity(Action<bool> completionHandler);

        // +(NSString * _Nonnull)applicationVersion;
        // +(void)setApplicationVersion:(NSString * _Nullable)appVersion;
        [Static]
        [Export("applicationVersion")]
        //[Verify(MethodToProperty)]
        string ApplicationVersion { get; set; }

        // +(NSString * _Nonnull)sdkVersion;
        [Static]
        [Export("sdkVersion")]
        //[Verify(MethodToProperty)]
        string SdkVersion { get; }

        // +(CLLocationManager * _Nullable)locationManager;
        [Static]
        [NullAllowed, Export("locationManager")]
        //[Verify(MethodToProperty)]
        CLLocationManager LocationManager { get; }

        // +(NSString * _Nullable)deviceId;
        [Static]
        [NullAllowed, Export("deviceId")]
        //[Verify(MethodToProperty)]
        string DeviceId { get; }

        // +(void)resetDeviceId;
        [Static]
        [Export("resetDeviceId")]
        void ResetDeviceId();

        // +(void)addAppEvent:(NSString * _Nonnull)eventKey data:(NSDictionary * _Nullable)data;
        [Static]
        [Export("addAppEvent:data:")]
        void AddAppEvent(string eventKey, [NullAllowed] NSDictionary data);

        // +(void)addAppEvent:(SASCollectorEvent * _Nonnull)event;
        [Static]
        [Export("addAppEvent:")]
        void AddAppEvent(SASCollectorEvent @event);

        // +(void)addAppEvents:(NSArray<SASCollectorEvent *> * _Nonnull)events;
        [Static]
        [Export("addAppEvents:")]
        void AddAppEvents(SASCollectorEvent[] events);

        // +(void)identity:(NSString * _Nonnull)value withType:(NSString * _Nonnull)type __attribute__((deprecated("This method produces inconsistent results. Use identity:withType:completion.")));
        [Static]
        [Export("identity:withType:")]
        void Identity(string value, string type);

        // +(void)identity:(NSString * _Nonnull)value withType:(NSString * _Nonnull)type completion:(void (^ _Nonnull)(_Bool))completionHandler;
        [Static]
        [Export("identity:withType:completion:")]
        void Identity(string value, string type, Action<bool> completionHandler);

        // +(void)detachIdentity:(void (^ _Nonnull)(_Bool))completionHandler;
        [Static]
        [Export("detachIdentity:")]
        void DetachIdentity(Action<bool> completionHandler);

        // +(void)newPage:(NSString * _Nonnull)uri;
        [Static]
        [Export("newPage:")]
        void NewPage(string uri);

        // +(void)registerForMobileMessages:(NSData * _Nonnull)deviceToken completionHandler:(void (^ _Nonnull)(void))completionHandler failureHandler:(void (^ _Nonnull)(void))failureHandler;
        [Static]
        [Export("registerForMobileMessages:completionHandler:failureHandler:")]
        void RegisterForMobileMessages(NSData deviceToken, Action completionHandler, Action failureHandler);

        // +(BOOL)handleMobileMessage:(NSDictionary * _Nonnull)userInfo WithApplication:(UIApplication * _Nonnull)application;
        [Static]
        [Export("handleMobileMessage:WithApplication:")]
        bool HandleMobileMessage(NSDictionary userInfo, UIApplication application);

        // +(void)determineIARequest:(NSString * _Nonnull)spotID completionHandler:(void (^ _Nonnull)(NSString * _Nonnull))completionHandler failureHandler:(void (^ _Nonnull)(NSError * _Nonnull))failureHandler badResponseHandler:(void (^ _Nonnull)(NSURLResponse * _Nonnull))badResponseHandler;
        [Static]
        [Export("determineIARequest:completionHandler:failureHandler:badResponseHandler:")]
        void DetermineIARequest(string spotID, Action<NSString> completionHandler, Action<NSError> failureHandler, Action<NSUrlResponse> badResponseHandler);

        // +(NSString * _Nullable)currentGEOFence;
        [Static]
        [NullAllowed, Export("currentGEOFence")]
        //[Verify(MethodToProperty)]
        string CurrentGEOFence { get; }

        // +(WKWebsiteDataStore * _Nullable)getConfiguredWKWebsiteDatastore;
        [Static]
        [NullAllowed, Export("getConfiguredWKWebsiteDatastore")]
        //[Verify(MethodToProperty)]
        WKWebsiteDataStore ConfiguredWKWebsiteDatastore { get; }

        // +(WKWebViewConfiguration * _Nullable)getSessionWKWebViewConfiguration;
        [Static]
        [NullAllowed, Export("getSessionWKWebViewConfiguration")]
        //[Verify(MethodToProperty)]
        WKWebViewConfiguration SessionWKWebViewConfiguration { get; }

        // +(NSString * _Nullable)getDecoratedWebSessionURL:(NSString * _Nonnull)url;
        [Static]
        [Export("getDecoratedWebSessionURL:")]
        [return: NullAllowed]
        string GetDecoratedWebSessionURL(string url);

        // +(NSString * _Nullable)getSessionBindingParamter;
        [Static]
        [NullAllowed, Export("getSessionBindingParamter")]
        //[Verify(MethodToProperty)]
        string SessionBindingParamter { get; }

        // +(void)skewClock:(NSTimeInterval)ms key:(NSString * _Nonnull)key;
        [Static]
        [Export("skewClock:key:")]
        void SkewClock(double ms, string key);

        // +(BOOL)isEnabled;
        [Static]
        [Export("isEnabled")]
        //[Verify(MethodToProperty)]
        bool IsEnabled { get; }
    }

}


//using System;

//using ObjCRuntime;
//using Foundation;
//using UIKit;

//namespace NativeLibrary
//{
//    // The first step to creating a binding is to add your native library ("libNativeLibrary.a")
//    // to the project by right-clicking (or Control-clicking) the folder containing this source
//    // file and clicking "Add files..." and then simply select the native library (or libraries)
//    // that you want to bind.
//    //
//    // When you do that, you'll notice that MonoDevelop generates a code-behind file for each
//    // native library which will contain a [LinkWith] attribute. VisualStudio auto-detects the
//    // architectures that the native library supports and fills in that information for you,
//    // however, it cannot auto-detect any Frameworks or other system libraries that the
//    // native library may depend on, so you'll need to fill in that information yourself.
//    //
//    // Once you've done that, you're ready to move on to binding the API...
//    //
//    //
//    // Here is where you'd define your API definition for the native Objective-C library.
//    //
//    // For example, to bind the following Objective-C class:
//    //
//    //     @interface Widget : NSObject {
//    //     }
//    //
//    // The C# binding would look like this:
//    //
//    //     [BaseType (typeof (NSObject))]
//    //     interface Widget {
//    //     }
//    //
//    // To bind Objective-C properties, such as:
//    //
//    //     @property (nonatomic, readwrite, assign) CGPoint center;
//    //
//    // You would add a property definition in the C# interface like so:
//    //
//    //     [Export ("center")]
//    //     CGPoint Center { get; set; }
//    //
//    // To bind an Objective-C method, such as:
//    //
//    //     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
//    //
//    // You would add a method definition to the C# interface like so:
//    //
//    //     [Export ("doSomething:atIndex:")]
//    //     void DoSomething (NSObject object, int index);
//    //
//    // Objective-C "constructors" such as:
//    //
//    //     -(id)initWithElmo:(ElmoMuppet *)elmo;
//    //
//    // Can be bound as:
//    //
//    //     [Export ("initWithElmo:")]
//    //     IntPtr Constructor (ElmoMuppet elmo);
//    //
//    // For more information, see https://aka.ms/ios-binding
//    //
//}


