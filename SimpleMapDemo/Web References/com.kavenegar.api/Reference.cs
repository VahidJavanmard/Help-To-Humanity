﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace SimpleMapDemo.com.kavenegar.api {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="SendSMSSoap", Namespace="http://ParsGreen.com/")]
    public partial class SendSMS : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback SendOtpOperationCompleted;
        
        private System.Threading.SendOrPostCallback MessageInfoOperationCompleted;
        
        private System.Threading.SendOrPostCallback SendGroupSMSOperationCompleted;
        
        private System.Threading.SendOrPostCallback SendOperationCompleted;
        
        private System.Threading.SendOrPostCallback SendGroupSMSP2POperationCompleted;
        
        private System.Threading.SendOrPostCallback SendToGroupOperationCompleted;
        
        private System.Threading.SendOrPostCallback SendGroupSmsSimpleOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetDeliveryOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetSMSNumbersOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public SendSMS() {
            this.Url = "http://login.parsgreen.com/Api/SendSMS.asmx";
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
        public event SendOtpCompletedEventHandler SendOtpCompleted;
        
        /// <remarks/>
        public event MessageInfoCompletedEventHandler MessageInfoCompleted;
        
        /// <remarks/>
        public event SendGroupSMSCompletedEventHandler SendGroupSMSCompleted;
        
        /// <remarks/>
        public event SendCompletedEventHandler SendCompleted;
        
        /// <remarks/>
        public event SendGroupSMSP2PCompletedEventHandler SendGroupSMSP2PCompleted;
        
        /// <remarks/>
        public event SendToGroupCompletedEventHandler SendToGroupCompleted;
        
        /// <remarks/>
        public event SendGroupSmsSimpleCompletedEventHandler SendGroupSmsSimpleCompleted;
        
        /// <remarks/>
        public event GetDeliveryCompletedEventHandler GetDeliveryCompleted;
        
        /// <remarks/>
        public event GetSMSNumbersCompletedEventHandler GetSMSNumbersCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://ParsGreen.com/SendOtp", RequestNamespace="http://ParsGreen.com/", ResponseNamespace="http://ParsGreen.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int SendOtp(string signature, string mobile, string Lang, int otpType, int patternId, out string otpCode) {
            object[] results = this.Invoke("SendOtp", new object[] {
                        signature,
                        mobile,
                        Lang,
                        otpType,
                        patternId});
            otpCode = ((string)(results[1]));
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void SendOtpAsync(string signature, string mobile, string Lang, int otpType, int patternId) {
            this.SendOtpAsync(signature, mobile, Lang, otpType, patternId, null);
        }
        
        /// <remarks/>
        public void SendOtpAsync(string signature, string mobile, string Lang, int otpType, int patternId, object userState) {
            if ((this.SendOtpOperationCompleted == null)) {
                this.SendOtpOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendOtpOperationCompleted);
            }
            this.InvokeAsync("SendOtp", new object[] {
                        signature,
                        mobile,
                        Lang,
                        otpType,
                        patternId}, this.SendOtpOperationCompleted, userState);
        }
        
        private void OnSendOtpOperationCompleted(object arg) {
            if ((this.SendOtpCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendOtpCompleted(this, new SendOtpCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://ParsGreen.com/MessageInfo", RequestNamespace="http://ParsGreen.com/", ResponseNamespace="http://ParsGreen.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public double MessageInfo(string signature, string MsgBody, ref int part, ref bool isUnicode) {
            object[] results = this.Invoke("MessageInfo", new object[] {
                        signature,
                        MsgBody,
                        part,
                        isUnicode});
            part = ((int)(results[1]));
            isUnicode = ((bool)(results[2]));
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void MessageInfoAsync(string signature, string MsgBody, int part, bool isUnicode) {
            this.MessageInfoAsync(signature, MsgBody, part, isUnicode, null);
        }
        
        /// <remarks/>
        public void MessageInfoAsync(string signature, string MsgBody, int part, bool isUnicode, object userState) {
            if ((this.MessageInfoOperationCompleted == null)) {
                this.MessageInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnMessageInfoOperationCompleted);
            }
            this.InvokeAsync("MessageInfo", new object[] {
                        signature,
                        MsgBody,
                        part,
                        isUnicode}, this.MessageInfoOperationCompleted, userState);
        }
        
        private void OnMessageInfoOperationCompleted(object arg) {
            if ((this.MessageInfoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.MessageInfoCompleted(this, new MessageInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://ParsGreen.com/SendGroupSMS", RequestNamespace="http://ParsGreen.com/", ResponseNamespace="http://ParsGreen.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int SendGroupSMS(string signature, string from, string[] to, string text, bool isFlash, string udh, ref int success, ref string[] retStr) {
            object[] results = this.Invoke("SendGroupSMS", new object[] {
                        signature,
                        from,
                        to,
                        text,
                        isFlash,
                        udh,
                        success,
                        retStr});
            success = ((int)(results[1]));
            retStr = ((string[])(results[2]));
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void SendGroupSMSAsync(string signature, string from, string[] to, string text, bool isFlash, string udh, int success, string[] retStr) {
            this.SendGroupSMSAsync(signature, from, to, text, isFlash, udh, success, retStr, null);
        }
        
        /// <remarks/>
        public void SendGroupSMSAsync(string signature, string from, string[] to, string text, bool isFlash, string udh, int success, string[] retStr, object userState) {
            if ((this.SendGroupSMSOperationCompleted == null)) {
                this.SendGroupSMSOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendGroupSMSOperationCompleted);
            }
            this.InvokeAsync("SendGroupSMS", new object[] {
                        signature,
                        from,
                        to,
                        text,
                        isFlash,
                        udh,
                        success,
                        retStr}, this.SendGroupSMSOperationCompleted, userState);
        }
        
        private void OnSendGroupSMSOperationCompleted(object arg) {
            if ((this.SendGroupSMSCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendGroupSMSCompleted(this, new SendGroupSMSCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://ParsGreen.com/Send", RequestNamespace="http://ParsGreen.com/", ResponseNamespace="http://ParsGreen.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int Send(string signature, string toMobile, string smsBody, ref string retStr) {
            object[] results = this.Invoke("Send", new object[] {
                        signature,
                        toMobile,
                        smsBody,
                        retStr});
            retStr = ((string)(results[1]));
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void SendAsync(string signature, string toMobile, string smsBody, string retStr) {
            this.SendAsync(signature, toMobile, smsBody, retStr, null);
        }
        
        /// <remarks/>
        public void SendAsync(string signature, string toMobile, string smsBody, string retStr, object userState) {
            if ((this.SendOperationCompleted == null)) {
                this.SendOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendOperationCompleted);
            }
            this.InvokeAsync("Send", new object[] {
                        signature,
                        toMobile,
                        smsBody,
                        retStr}, this.SendOperationCompleted, userState);
        }
        
        private void OnSendOperationCompleted(object arg) {
            if ((this.SendCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendCompleted(this, new SendCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://ParsGreen.com/SendGroupSMSP2P", RequestNamespace="http://ParsGreen.com/", ResponseNamespace="http://ParsGreen.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int SendGroupSMSP2P(string signature, string from, string[] to, string[] texts, bool isFlash, string udh, ref int[] status, ref int[] success, ref string[] retStr) {
            object[] results = this.Invoke("SendGroupSMSP2P", new object[] {
                        signature,
                        from,
                        to,
                        texts,
                        isFlash,
                        udh,
                        status,
                        success,
                        retStr});
            status = ((int[])(results[1]));
            success = ((int[])(results[2]));
            retStr = ((string[])(results[3]));
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void SendGroupSMSP2PAsync(string signature, string from, string[] to, string[] texts, bool isFlash, string udh, int[] status, int[] success, string[] retStr) {
            this.SendGroupSMSP2PAsync(signature, from, to, texts, isFlash, udh, status, success, retStr, null);
        }
        
        /// <remarks/>
        public void SendGroupSMSP2PAsync(string signature, string from, string[] to, string[] texts, bool isFlash, string udh, int[] status, int[] success, string[] retStr, object userState) {
            if ((this.SendGroupSMSP2POperationCompleted == null)) {
                this.SendGroupSMSP2POperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendGroupSMSP2POperationCompleted);
            }
            this.InvokeAsync("SendGroupSMSP2P", new object[] {
                        signature,
                        from,
                        to,
                        texts,
                        isFlash,
                        udh,
                        status,
                        success,
                        retStr}, this.SendGroupSMSP2POperationCompleted, userState);
        }
        
        private void OnSendGroupSMSP2POperationCompleted(object arg) {
            if ((this.SendGroupSMSP2PCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendGroupSMSP2PCompleted(this, new SendGroupSMSP2PCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://ParsGreen.com/SendToGroup", RequestNamespace="http://ParsGreen.com/", ResponseNamespace="http://ParsGreen.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int SendToGroup(string signature, string from, string groupIdEncrypt, string text, bool isFlash, string udh, ref int success, ref string[] retStr) {
            object[] results = this.Invoke("SendToGroup", new object[] {
                        signature,
                        from,
                        groupIdEncrypt,
                        text,
                        isFlash,
                        udh,
                        success,
                        retStr});
            success = ((int)(results[1]));
            retStr = ((string[])(results[2]));
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void SendToGroupAsync(string signature, string from, string groupIdEncrypt, string text, bool isFlash, string udh, int success, string[] retStr) {
            this.SendToGroupAsync(signature, from, groupIdEncrypt, text, isFlash, udh, success, retStr, null);
        }
        
        /// <remarks/>
        public void SendToGroupAsync(string signature, string from, string groupIdEncrypt, string text, bool isFlash, string udh, int success, string[] retStr, object userState) {
            if ((this.SendToGroupOperationCompleted == null)) {
                this.SendToGroupOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendToGroupOperationCompleted);
            }
            this.InvokeAsync("SendToGroup", new object[] {
                        signature,
                        from,
                        groupIdEncrypt,
                        text,
                        isFlash,
                        udh,
                        success,
                        retStr}, this.SendToGroupOperationCompleted, userState);
        }
        
        private void OnSendToGroupOperationCompleted(object arg) {
            if ((this.SendToGroupCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendToGroupCompleted(this, new SendToGroupCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://ParsGreen.com/SendGroupSmsSimple", RequestNamespace="http://ParsGreen.com/", ResponseNamespace="http://ParsGreen.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int SendGroupSmsSimple(string signature, string from, string[] to, string text, bool isFlash, string udh) {
            object[] results = this.Invoke("SendGroupSmsSimple", new object[] {
                        signature,
                        from,
                        to,
                        text,
                        isFlash,
                        udh});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void SendGroupSmsSimpleAsync(string signature, string from, string[] to, string text, bool isFlash, string udh) {
            this.SendGroupSmsSimpleAsync(signature, from, to, text, isFlash, udh, null);
        }
        
        /// <remarks/>
        public void SendGroupSmsSimpleAsync(string signature, string from, string[] to, string text, bool isFlash, string udh, object userState) {
            if ((this.SendGroupSmsSimpleOperationCompleted == null)) {
                this.SendGroupSmsSimpleOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendGroupSmsSimpleOperationCompleted);
            }
            this.InvokeAsync("SendGroupSmsSimple", new object[] {
                        signature,
                        from,
                        to,
                        text,
                        isFlash,
                        udh}, this.SendGroupSmsSimpleOperationCompleted, userState);
        }
        
        private void OnSendGroupSmsSimpleOperationCompleted(object arg) {
            if ((this.SendGroupSmsSimpleCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendGroupSmsSimpleCompleted(this, new SendGroupSmsSimpleCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://ParsGreen.com/GetDelivery", RequestNamespace="http://ParsGreen.com/", ResponseNamespace="http://ParsGreen.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int GetDelivery(string signature, string recId) {
            object[] results = this.Invoke("GetDelivery", new object[] {
                        signature,
                        recId});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void GetDeliveryAsync(string signature, string recId) {
            this.GetDeliveryAsync(signature, recId, null);
        }
        
        /// <remarks/>
        public void GetDeliveryAsync(string signature, string recId, object userState) {
            if ((this.GetDeliveryOperationCompleted == null)) {
                this.GetDeliveryOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDeliveryOperationCompleted);
            }
            this.InvokeAsync("GetDelivery", new object[] {
                        signature,
                        recId}, this.GetDeliveryOperationCompleted, userState);
        }
        
        private void OnGetDeliveryOperationCompleted(object arg) {
            if ((this.GetDeliveryCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDeliveryCompleted(this, new GetDeliveryCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://ParsGreen.com/GetSMSNumbers", RequestNamespace="http://ParsGreen.com/", ResponseNamespace="http://ParsGreen.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int GetSMSNumbers(string signature, int numberType, ref string[] numbers) {
            object[] results = this.Invoke("GetSMSNumbers", new object[] {
                        signature,
                        numberType,
                        numbers});
            numbers = ((string[])(results[1]));
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void GetSMSNumbersAsync(string signature, int numberType, string[] numbers) {
            this.GetSMSNumbersAsync(signature, numberType, numbers, null);
        }
        
        /// <remarks/>
        public void GetSMSNumbersAsync(string signature, int numberType, string[] numbers, object userState) {
            if ((this.GetSMSNumbersOperationCompleted == null)) {
                this.GetSMSNumbersOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetSMSNumbersOperationCompleted);
            }
            this.InvokeAsync("GetSMSNumbers", new object[] {
                        signature,
                        numberType,
                        numbers}, this.GetSMSNumbersOperationCompleted, userState);
        }
        
        private void OnGetSMSNumbersOperationCompleted(object arg) {
            if ((this.GetSMSNumbersCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetSMSNumbersCompleted(this, new GetSMSNumbersCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public delegate void SendOtpCompletedEventHandler(object sender, SendOtpCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SendOtpCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SendOtpCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public string otpCode {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void MessageInfoCompletedEventHandler(object sender, MessageInfoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MessageInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal MessageInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public int part {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[1]));
            }
        }
        
        /// <remarks/>
        public bool isUnicode {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[2]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void SendGroupSMSCompletedEventHandler(object sender, SendGroupSMSCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SendGroupSMSCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SendGroupSMSCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public int success {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[1]));
            }
        }
        
        /// <remarks/>
        public string[] retStr {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[2]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void SendCompletedEventHandler(object sender, SendCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SendCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SendCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public string retStr {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void SendGroupSMSP2PCompletedEventHandler(object sender, SendGroupSMSP2PCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SendGroupSMSP2PCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SendGroupSMSP2PCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public int[] status {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int[])(this.results[1]));
            }
        }
        
        /// <remarks/>
        public int[] success {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int[])(this.results[2]));
            }
        }
        
        /// <remarks/>
        public string[] retStr {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[3]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void SendToGroupCompletedEventHandler(object sender, SendToGroupCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SendToGroupCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SendToGroupCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public int success {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[1]));
            }
        }
        
        /// <remarks/>
        public string[] retStr {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[2]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void SendGroupSmsSimpleCompletedEventHandler(object sender, SendGroupSmsSimpleCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SendGroupSmsSimpleCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SendGroupSmsSimpleCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void GetDeliveryCompletedEventHandler(object sender, GetDeliveryCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDeliveryCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetDeliveryCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void GetSMSNumbersCompletedEventHandler(object sender, GetSMSNumbersCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetSMSNumbersCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetSMSNumbersCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public string[] numbers {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[1]));
            }
        }
    }
}

#pragma warning restore 1591