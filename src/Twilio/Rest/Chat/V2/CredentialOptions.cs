/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Chat.V2 
{

    /// <summary>
    /// ReadCredentialOptions
    /// </summary>
    public class ReadCredentialOptions : ReadOptions<CredentialResource> 
    {
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// CreateCredentialOptions
    /// </summary>
    public class CreateCredentialOptions : IOptions<CredentialResource> 
    {
        /// <summary>
        /// Credential type, one of "gcm", "fcm", or "apn"
        /// </summary>
        public CredentialResource.PushServiceEnum Type { get; }
        /// <summary>
        /// Friendly name for stored credential
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// [APN only] URL encoded representation of the certificate, e.
        /// </summary>
        public string Certificate { get; set; }
        /// <summary>
        /// [APN only] URL encoded representation of the private key, e.
        /// </summary>
        public string PrivateKey { get; set; }
        /// <summary>
        /// [APN only] use this credential for sending to production or sandbox APNs
        /// </summary>
        public bool? Sandbox { get; set; }
        /// <summary>
        /// [GCM only] This is the "API key" for project from Google Developer console for your GCM Service application credential
        /// </summary>
        public string ApiKey { get; set; }
        /// <summary>
        /// [FCM only] This is the "Server key" of your project from Firebase console under Settings / Cloud messaging.
        /// </summary>
        public string Secret { get; set; }

        /// <summary>
        /// Construct a new CreateCredentialOptions
        /// </summary>
        /// <param name="type"> Credential type, one of "gcm", "fcm", or "apn" </param>
        public CreateCredentialOptions(CredentialResource.PushServiceEnum type)
        {
            Type = type;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Type != null)
            {
                p.Add(new KeyValuePair<string, string>("Type", Type.ToString()));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (Certificate != null)
            {
                p.Add(new KeyValuePair<string, string>("Certificate", Certificate));
            }

            if (PrivateKey != null)
            {
                p.Add(new KeyValuePair<string, string>("PrivateKey", PrivateKey));
            }

            if (Sandbox != null)
            {
                p.Add(new KeyValuePair<string, string>("Sandbox", Sandbox.Value.ToString().ToLower()));
            }

            if (ApiKey != null)
            {
                p.Add(new KeyValuePair<string, string>("ApiKey", ApiKey));
            }

            if (Secret != null)
            {
                p.Add(new KeyValuePair<string, string>("Secret", Secret));
            }

            return p;
        }
    }

    /// <summary>
    /// FetchCredentialOptions
    /// </summary>
    public class FetchCredentialOptions : IOptions<CredentialResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchCredentialOptions
        /// </summary>
        /// <param name="pathSid"> The sid </param>
        public FetchCredentialOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// UpdateCredentialOptions
    /// </summary>
    public class UpdateCredentialOptions : IOptions<CredentialResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// Friendly name for stored credential
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// [APN only] URL encoded representation of the certificate, e.
        /// </summary>
        public string Certificate { get; set; }
        /// <summary>
        /// [APN only] URL encoded representation of the private key, e.
        /// </summary>
        public string PrivateKey { get; set; }
        /// <summary>
        /// [APN only] use this credential for sending to production or sandbox APNs
        /// </summary>
        public bool? Sandbox { get; set; }
        /// <summary>
        /// [GCM only] This is the "API key" for project from Google Developer console for your GCM Service application credential
        /// </summary>
        public string ApiKey { get; set; }
        /// <summary>
        /// [FCM only] This is the "Server key" of your project from Firebase console under Settings / Cloud messaging.
        /// </summary>
        public string Secret { get; set; }

        /// <summary>
        /// Construct a new UpdateCredentialOptions
        /// </summary>
        /// <param name="pathSid"> The sid </param>
        public UpdateCredentialOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (Certificate != null)
            {
                p.Add(new KeyValuePair<string, string>("Certificate", Certificate));
            }

            if (PrivateKey != null)
            {
                p.Add(new KeyValuePair<string, string>("PrivateKey", PrivateKey));
            }

            if (Sandbox != null)
            {
                p.Add(new KeyValuePair<string, string>("Sandbox", Sandbox.Value.ToString().ToLower()));
            }

            if (ApiKey != null)
            {
                p.Add(new KeyValuePair<string, string>("ApiKey", ApiKey));
            }

            if (Secret != null)
            {
                p.Add(new KeyValuePair<string, string>("Secret", Secret));
            }

            return p;
        }
    }

    /// <summary>
    /// DeleteCredentialOptions
    /// </summary>
    public class DeleteCredentialOptions : IOptions<CredentialResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteCredentialOptions
        /// </summary>
        /// <param name="pathSid"> The sid </param>
        public DeleteCredentialOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

}