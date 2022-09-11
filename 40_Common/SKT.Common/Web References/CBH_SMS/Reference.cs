﻿//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 이 소스 코드가 Microsoft.VSDesigner, 버전 4.0.30319.42000에서 자동으로 생성되었습니다.
// 
#pragma warning disable 1591

namespace SKT.Common.CBH_SMS {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="SMSSenderServiceSoapBinding", Namespace="http://skt/soa/notification/webservice")]
    public partial class SMSSenderService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback sendOperationCompleted;
        
        private System.Threading.SendOrPostCallback cancelOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public SMSSenderService() {
            this.Url = global::SKT.Common.Properties.Settings.Default.SKT_Common_CBH_SMS_SMSSenderService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event sendCompletedEventHandler sendCompleted;
        
        /// <remarks/>
        public event cancelCompletedEventHandler cancelCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://skt/soa/notification/webservice", ResponseNamespace="http://skt/soa/notification/webservice", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return")]
        public string send(string CONSUMER_ID, string RPLY_PHON_NUM, string TITLE, string PHONE, string URL, string START_DT_HMS, string END_DT_HMS, out string uuid) {
            object[] results = this.Invoke("send", new object[] {
                        CONSUMER_ID,
                        RPLY_PHON_NUM,
                        TITLE,
                        PHONE,
                        URL,
                        START_DT_HMS,
                        END_DT_HMS});
            uuid = ((string)(results[1]));
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void sendAsync(string CONSUMER_ID, string RPLY_PHON_NUM, string TITLE, string PHONE, string URL, string START_DT_HMS, string END_DT_HMS) {
            this.sendAsync(CONSUMER_ID, RPLY_PHON_NUM, TITLE, PHONE, URL, START_DT_HMS, END_DT_HMS, null);
        }
        
        /// <remarks/>
        public void sendAsync(string CONSUMER_ID, string RPLY_PHON_NUM, string TITLE, string PHONE, string URL, string START_DT_HMS, string END_DT_HMS, object userState) {
            if ((this.sendOperationCompleted == null)) {
                this.sendOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsendOperationCompleted);
            }
            this.InvokeAsync("send", new object[] {
                        CONSUMER_ID,
                        RPLY_PHON_NUM,
                        TITLE,
                        PHONE,
                        URL,
                        START_DT_HMS,
                        END_DT_HMS}, this.sendOperationCompleted, userState);
        }
        
        private void OnsendOperationCompleted(object arg) {
            if ((this.sendCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.sendCompleted(this, new sendCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://skt/soa/notification/webservice", ResponseNamespace="http://skt/soa/notification/webservice", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return")]
        public string cancel(string UUID) {
            object[] results = this.Invoke("cancel", new object[] {
                        UUID});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void cancelAsync(string UUID) {
            this.cancelAsync(UUID, null);
        }
        
        /// <remarks/>
        public void cancelAsync(string UUID, object userState) {
            if ((this.cancelOperationCompleted == null)) {
                this.cancelOperationCompleted = new System.Threading.SendOrPostCallback(this.OncancelOperationCompleted);
            }
            this.InvokeAsync("cancel", new object[] {
                        UUID}, this.cancelOperationCompleted, userState);
        }
        
        private void OncancelOperationCompleted(object arg) {
            if ((this.cancelCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.cancelCompleted(this, new cancelCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void sendCompletedEventHandler(object sender, sendCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class sendCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal sendCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public string uuid {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void cancelCompletedEventHandler(object sender, cancelCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class cancelCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal cancelCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591