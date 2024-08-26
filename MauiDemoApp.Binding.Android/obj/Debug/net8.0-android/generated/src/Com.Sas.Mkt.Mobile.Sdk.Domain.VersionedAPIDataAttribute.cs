using System;

namespace Com.Sas.Mkt.Mobile.Sdk.Domain {

	[global::Android.Runtime.Annotation ("com.sas.mkt.mobile.sdk.domain.VersionedAPIData")]
	public partial class VersionedAPIDataAttribute : Attribute
	{
		[global::Android.Runtime.Register ("contentType")]
		public string? ContentType { get; set; }

	}
}
