//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Weather.eklima.met.no {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="MetDataServiceBinding", Namespace="http://no/met/metdata/MetDataService.wsdl")]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(no_met_metdata_CountyTypes))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(no_met_metdata_PrecipitationTypes))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(no_met_metdata_FlagProperties))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(no_met_metdata_StationProperties))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(no_met_metdata_ElementProperties))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(no_met_metdata_TimeSerieTypes))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(no_met_metdata_WeatherElement))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(no_met_metdata_Location))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(no_met_metdata_TimeStamp))]
    public partial class MetDataService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public MetDataService() {
            this.Url = "http://eklima.met.no/metdata/MetDataService";
        }
        
        public MetDataService(string url) {
            this.Url = url;
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="MetDataService", ResponseNamespace="MetDataService")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public no_met_metdata_Metdata getMetData(string timeserietypeID, string format, string from, string to, string stations, string elements, string hours, string months, string username) {
            object[] results = this.Invoke("getMetData", new object[] {
                        timeserietypeID,
                        format,
                        from,
                        to,
                        stations,
                        elements,
                        hours,
                        months,
                        username});
            return ((no_met_metdata_Metdata)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetMetData(string timeserietypeID, string format, string from, string to, string stations, string elements, string hours, string months, string username, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getMetData", new object[] {
                        timeserietypeID,
                        format,
                        from,
                        to,
                        stations,
                        elements,
                        hours,
                        months,
                        username}, callback, asyncState);
        }
        
        /// <remarks/>
        public no_met_metdata_Metdata EndgetMetData(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((no_met_metdata_Metdata)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="MetDataService", ResponseNamespace="MetDataService")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public string getControlInfo(string format, string from, string to, string stations, string elements, string hours, string months, string username) {
            object[] results = this.Invoke("getControlInfo", new object[] {
                        format,
                        from,
                        to,
                        stations,
                        elements,
                        hours,
                        months,
                        username});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetControlInfo(string format, string from, string to, string stations, string elements, string hours, string months, string username, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getControlInfo", new object[] {
                        format,
                        from,
                        to,
                        stations,
                        elements,
                        hours,
                        months,
                        username}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndgetControlInfo(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="MetDataService", ResponseNamespace="MetDataService")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public no_met_metdata_TimeSerieTypes[] getTimeserieTypesProperties(string language, string timeserieTypes) {
            object[] results = this.Invoke("getTimeserieTypesProperties", new object[] {
                        language,
                        timeserieTypes});
            return ((no_met_metdata_TimeSerieTypes[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetTimeserieTypesProperties(string language, string timeserieTypes, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getTimeserieTypesProperties", new object[] {
                        language,
                        timeserieTypes}, callback, asyncState);
        }
        
        /// <remarks/>
        public no_met_metdata_TimeSerieTypes[] EndgetTimeserieTypesProperties(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((no_met_metdata_TimeSerieTypes[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="MetDataService", ResponseNamespace="MetDataService")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public no_met_metdata_ElementProperties[] getElementsProperties(string language, string elem_codes) {
            object[] results = this.Invoke("getElementsProperties", new object[] {
                        language,
                        elem_codes});
            return ((no_met_metdata_ElementProperties[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetElementsProperties(string language, string elem_codes, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getElementsProperties", new object[] {
                        language,
                        elem_codes}, callback, asyncState);
        }
        
        /// <remarks/>
        public no_met_metdata_ElementProperties[] EndgetElementsProperties(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((no_met_metdata_ElementProperties[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="MetDataService", ResponseNamespace="MetDataService")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public no_met_metdata_ElementProperties[] getElementsFromTimeserieType(string timeserietypeID) {
            object[] results = this.Invoke("getElementsFromTimeserieType", new object[] {
                        timeserietypeID});
            return ((no_met_metdata_ElementProperties[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetElementsFromTimeserieType(string timeserietypeID, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getElementsFromTimeserieType", new object[] {
                        timeserietypeID}, callback, asyncState);
        }
        
        /// <remarks/>
        public no_met_metdata_ElementProperties[] EndgetElementsFromTimeserieType(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((no_met_metdata_ElementProperties[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="MetDataService", ResponseNamespace="MetDataService")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public no_met_metdata_ElementProperties[] getElementsFromTimeserieTypeStation(string timeserietypeID, int stnr) {
            object[] results = this.Invoke("getElementsFromTimeserieTypeStation", new object[] {
                        timeserietypeID,
                        stnr});
            return ((no_met_metdata_ElementProperties[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetElementsFromTimeserieTypeStation(string timeserietypeID, int stnr, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getElementsFromTimeserieTypeStation", new object[] {
                        timeserietypeID,
                        stnr}, callback, asyncState);
        }
        
        /// <remarks/>
        public no_met_metdata_ElementProperties[] EndgetElementsFromTimeserieTypeStation(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((no_met_metdata_ElementProperties[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="MetDataService", ResponseNamespace="MetDataService")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public no_met_metdata_StationProperties[] getStationsProperties(string stations, string username) {
            object[] results = this.Invoke("getStationsProperties", new object[] {
                        stations,
                        username});
            return ((no_met_metdata_StationProperties[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetStationsProperties(string stations, string username, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getStationsProperties", new object[] {
                        stations,
                        username}, callback, asyncState);
        }
        
        /// <remarks/>
        public no_met_metdata_StationProperties[] EndgetStationsProperties(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((no_met_metdata_StationProperties[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="MetDataService", ResponseNamespace="MetDataService")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public no_met_metdata_StationProperties[] getStationsFromTimeserieType(string timeserietypeID, string username) {
            object[] results = this.Invoke("getStationsFromTimeserieType", new object[] {
                        timeserietypeID,
                        username});
            return ((no_met_metdata_StationProperties[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetStationsFromTimeserieType(string timeserietypeID, string username, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getStationsFromTimeserieType", new object[] {
                        timeserietypeID,
                        username}, callback, asyncState);
        }
        
        /// <remarks/>
        public no_met_metdata_StationProperties[] EndgetStationsFromTimeserieType(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((no_met_metdata_StationProperties[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="MetDataService", ResponseNamespace="MetDataService")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public no_met_metdata_StationProperties[] getStationsFromTimeserieTypeElemCodes(string timeserietypeID, string elem_codes, string username) {
            object[] results = this.Invoke("getStationsFromTimeserieTypeElemCodes", new object[] {
                        timeserietypeID,
                        elem_codes,
                        username});
            return ((no_met_metdata_StationProperties[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetStationsFromTimeserieTypeElemCodes(string timeserietypeID, string elem_codes, string username, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getStationsFromTimeserieTypeElemCodes", new object[] {
                        timeserietypeID,
                        elem_codes,
                        username}, callback, asyncState);
        }
        
        /// <remarks/>
        public no_met_metdata_StationProperties[] EndgetStationsFromTimeserieTypeElemCodes(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((no_met_metdata_StationProperties[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="MetDataService", ResponseNamespace="MetDataService")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public no_met_metdata_StationProperties[] getStationsFromTimeserieTypeStationsElemCode(string timeserietype, string stations, string elem_code, string username) {
            object[] results = this.Invoke("getStationsFromTimeserieTypeStationsElemCode", new object[] {
                        timeserietype,
                        stations,
                        elem_code,
                        username});
            return ((no_met_metdata_StationProperties[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetStationsFromTimeserieTypeStationsElemCode(string timeserietype, string stations, string elem_code, string username, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getStationsFromTimeserieTypeStationsElemCode", new object[] {
                        timeserietype,
                        stations,
                        elem_code,
                        username}, callback, asyncState);
        }
        
        /// <remarks/>
        public no_met_metdata_StationProperties[] EndgetStationsFromTimeserieTypeStationsElemCode(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((no_met_metdata_StationProperties[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="MetDataService", ResponseNamespace="MetDataService")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public string getDateFormat() {
            object[] results = this.Invoke("getDateFormat", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetDateFormat(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getDateFormat", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public string EndgetDateFormat(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="MetDataService", ResponseNamespace="MetDataService")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public no_met_metdata_FlagProperties[] getFlagProperties(string language, string flagsId) {
            object[] results = this.Invoke("getFlagProperties", new object[] {
                        language,
                        flagsId});
            return ((no_met_metdata_FlagProperties[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetFlagProperties(string language, string flagsId, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getFlagProperties", new object[] {
                        language,
                        flagsId}, callback, asyncState);
        }
        
        /// <remarks/>
        public no_met_metdata_FlagProperties[] EndgetFlagProperties(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((no_met_metdata_FlagProperties[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="MetDataService", ResponseNamespace="MetDataService")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public no_met_metdata_PrecipitationTypes[] getPrecipitationTypes(string language, string precipitationTypesId) {
            object[] results = this.Invoke("getPrecipitationTypes", new object[] {
                        language,
                        precipitationTypesId});
            return ((no_met_metdata_PrecipitationTypes[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetPrecipitationTypes(string language, string precipitationTypesId, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getPrecipitationTypes", new object[] {
                        language,
                        precipitationTypesId}, callback, asyncState);
        }
        
        /// <remarks/>
        public no_met_metdata_PrecipitationTypes[] EndgetPrecipitationTypes(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((no_met_metdata_PrecipitationTypes[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="MetDataService", ResponseNamespace="MetDataService")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public string[] getValidLanguages() {
            object[] results = this.Invoke("getValidLanguages", new object[0]);
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetValidLanguages(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getValidLanguages", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public string[] EndgetValidLanguages(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="MetDataService", ResponseNamespace="MetDataService")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public no_met_metdata_CountyTypes[] getCountyTypes(string language, string countiesId) {
            object[] results = this.Invoke("getCountyTypes", new object[] {
                        language,
                        countiesId});
            return ((no_met_metdata_CountyTypes[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetCountyTypes(string language, string countiesId, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getCountyTypes", new object[] {
                        language,
                        countiesId}, callback, asyncState);
        }
        
        /// <remarks/>
        public no_met_metdata_CountyTypes[] EndgetCountyTypes(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((no_met_metdata_CountyTypes[])(results[0]));
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://no.met.metdata/IMetDataService.xsd")]
    public partial class no_met_metdata_Metdata {
        
        /// <remarks/>
        public System.DateTime created;
        
        /// <remarks/>
        public string type;
        
        /// <remarks/>
        public no_met_metdata_TimeStamp[] timeStamp;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://no.met.metdata/IMetDataService.xsd")]
    public partial class no_met_metdata_TimeStamp {
        
        /// <remarks/>
        public System.DateTime from;
        
        /// <remarks/>
        public no_met_metdata_Location[] location;
        
        /// <remarks/>
        public System.DateTime to;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://no.met.metdata/IMetDataService.xsd")]
    public partial class no_met_metdata_Location {
        
        /// <remarks/>
        public int id;
        
        /// <remarks/>
        public string type;
        
        /// <remarks/>
        public no_met_metdata_WeatherElement[] weatherElement;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://no.met.metdata/IMetDataService.xsd")]
    public partial class no_met_metdata_WeatherElement {
        
        /// <remarks/>
        public string id;
        
        /// <remarks/>
        public int quality;
        
        /// <remarks/>
        public string value;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://no.met.metdata/IMetDataService.xsd")]
    public partial class no_met_metdata_CountyTypes {
        
        /// <remarks/>
        public string language;
        
        /// <remarks/>
        public string countyName;
        
        /// <remarks/>
        public int countyID;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://no.met.metdata/IMetDataService.xsd")]
    public partial class no_met_metdata_PrecipitationTypes {
        
        /// <remarks/>
        public string language;
        
        /// <remarks/>
        public string precipitationCode;
        
        /// <remarks/>
        public int precipitationID;
        
        /// <remarks/>
        public string precipitationDescription;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://no.met.metdata/IMetDataService.xsd")]
    public partial class no_met_metdata_FlagProperties {
        
        /// <remarks/>
        public string language;
        
        /// <remarks/>
        public string flagName;
        
        /// <remarks/>
        public int flagID;
        
        /// <remarks/>
        public string flagDescription;
        
        /// <remarks/>
        public string flagCode;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://no.met.metdata/IMetDataService.xsd")]
    public partial class no_met_metdata_StationProperties {
        
        /// <remarks/>
        public string name;
        
        /// <remarks/>
        public int stnr;
        
        /// <remarks/>
        public int wmoNo;
        
        /// <remarks/>
        public int amsl;
        
        /// <remarks/>
        public string department;
        
        /// <remarks/>
        public int municipalityNo;
        
        /// <remarks/>
        public int fromYear;
        
        /// <remarks/>
        public int fromMonth;
        
        /// <remarks/>
        public int fromDay;
        
        /// <remarks/>
        public int toYear;
        
        /// <remarks/>
        public int toMonth;
        
        /// <remarks/>
        public int toDay;
        
        /// <remarks/>
        public int utm_e;
        
        /// <remarks/>
        public int utm_n;
        
        /// <remarks/>
        public int utm_zone;
        
        /// <remarks/>
        public double latDec;
        
        /// <remarks/>
        public double lonDec;
        
        /// <remarks/>
        public string latLonFmt;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://no.met.metdata/IMetDataService.xsd")]
    public partial class no_met_metdata_ElementProperties {
        
        /// <remarks/>
        public string elemCode;
        
        /// <remarks/>
        public int elemNo;
        
        /// <remarks/>
        public string description;
        
        /// <remarks/>
        public string unit;
        
        /// <remarks/>
        public string name;
        
        /// <remarks/>
        public string elemGroup;
        
        /// <remarks/>
        public string language;
        
        /// <remarks/>
        public System.DateTime fromdate;
        
        /// <remarks/>
        public System.DateTime todate;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XamarinStudio", "4.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://no.met.metdata/IMetDataService.xsd")]
    public partial class no_met_metdata_TimeSerieTypes {
        
        /// <remarks/>
        public string language;
        
        /// <remarks/>
        public string table;
        
        /// <remarks/>
        public string elemTable;
        
        /// <remarks/>
        public string serieTypeName;
        
        /// <remarks/>
        public int serieTypeID;
        
        /// <remarks/>
        public string serieTypeDescription;
    }
}