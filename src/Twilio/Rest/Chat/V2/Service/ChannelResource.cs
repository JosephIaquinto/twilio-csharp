/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// ChannelResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Chat.V2.Service 
{

    public class ChannelResource : Resource 
    {
        public sealed class ChannelTypeEnum : StringEnum 
        {
            private ChannelTypeEnum(string value) : base(value) {}
            public ChannelTypeEnum() {}
            public static implicit operator ChannelTypeEnum(string value)
            {
                return new ChannelTypeEnum(value);
            }

            public static readonly ChannelTypeEnum Public = new ChannelTypeEnum("public");
            public static readonly ChannelTypeEnum Private = new ChannelTypeEnum("private");
        }

        private static Request BuildFetchRequest(FetchChannelOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Chat,
                "/v2/Services/" + options.PathServiceSid + "/Channels/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Channel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Channel </returns> 
        public static ChannelResource Fetch(FetchChannelOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Channel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Channel </returns> 
        public static async System.Threading.Tasks.Task<ChannelResource> FetchAsync(FetchChannelOptions options, 
                                                                                    ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Channel </returns> 
        public static ChannelResource Fetch(string pathServiceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchChannelOptions(pathServiceSid, pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Channel </returns> 
        public static async System.Threading.Tasks.Task<ChannelResource> FetchAsync(string pathServiceSid, 
                                                                                    string pathSid, 
                                                                                    ITwilioRestClient client = null)
        {
            var options = new FetchChannelOptions(pathServiceSid, pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteChannelOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Chat,
                "/v2/Services/" + options.PathServiceSid + "/Channels/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete Channel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Channel </returns> 
        public static bool Delete(DeleteChannelOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete Channel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Channel </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteChannelOptions options, 
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Channel </returns> 
        public static bool Delete(string pathServiceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteChannelOptions(pathServiceSid, pathSid);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Channel </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathServiceSid, 
                                                                          string pathSid, 
                                                                          ITwilioRestClient client = null)
        {
            var options = new DeleteChannelOptions(pathServiceSid, pathSid);
            return await DeleteAsync(options, client);
        }
        #endif

        private static Request BuildCreateRequest(CreateChannelOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Chat,
                "/v2/Services/" + options.PathServiceSid + "/Channels",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create Channel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Channel </returns> 
        public static ChannelResource Create(CreateChannelOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create Channel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Channel </returns> 
        public static async System.Threading.Tasks.Task<ChannelResource> CreateAsync(CreateChannelOptions options, 
                                                                                     ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// create
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="friendlyName"> A human-readable name for the Channel. </param>
        /// <param name="uniqueName"> A unique, addressable name for the Channel. </param>
        /// <param name="attributes"> An optional metadata field you can use to store any data you wish. </param>
        /// <param name="type"> The visibility of the channel - public or private. </param>
        /// <param name="dateCreated"> The optional ISO8601 time specifying the datetime the Channel should be set as being
        ///                   created. </param>
        /// <param name="dateUpdated"> The optional ISO8601 time specifying the datetime the Channel should be set as having
        ///                   been last updated. </param>
        /// <param name="createdBy"> Optional field to specify the Identity of the User that created the Channel. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Channel </returns> 
        public static ChannelResource Create(string pathServiceSid, 
                                             string friendlyName = null, 
                                             string uniqueName = null, 
                                             string attributes = null, 
                                             ChannelResource.ChannelTypeEnum type = null, 
                                             DateTime? dateCreated = null, 
                                             DateTime? dateUpdated = null, 
                                             string createdBy = null, 
                                             ITwilioRestClient client = null)
        {
            var options = new CreateChannelOptions(pathServiceSid){FriendlyName = friendlyName, UniqueName = uniqueName, Attributes = attributes, Type = type, DateCreated = dateCreated, DateUpdated = dateUpdated, CreatedBy = createdBy};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="friendlyName"> A human-readable name for the Channel. </param>
        /// <param name="uniqueName"> A unique, addressable name for the Channel. </param>
        /// <param name="attributes"> An optional metadata field you can use to store any data you wish. </param>
        /// <param name="type"> The visibility of the channel - public or private. </param>
        /// <param name="dateCreated"> The optional ISO8601 time specifying the datetime the Channel should be set as being
        ///                   created. </param>
        /// <param name="dateUpdated"> The optional ISO8601 time specifying the datetime the Channel should be set as having
        ///                   been last updated. </param>
        /// <param name="createdBy"> Optional field to specify the Identity of the User that created the Channel. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Channel </returns> 
        public static async System.Threading.Tasks.Task<ChannelResource> CreateAsync(string pathServiceSid, 
                                                                                     string friendlyName = null, 
                                                                                     string uniqueName = null, 
                                                                                     string attributes = null, 
                                                                                     ChannelResource.ChannelTypeEnum type = null, 
                                                                                     DateTime? dateCreated = null, 
                                                                                     DateTime? dateUpdated = null, 
                                                                                     string createdBy = null, 
                                                                                     ITwilioRestClient client = null)
        {
            var options = new CreateChannelOptions(pathServiceSid){FriendlyName = friendlyName, UniqueName = uniqueName, Attributes = attributes, Type = type, DateCreated = dateCreated, DateUpdated = dateUpdated, CreatedBy = createdBy};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadChannelOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Chat,
                "/v2/Services/" + options.PathServiceSid + "/Channels",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Channel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Channel </returns> 
        public static ResourceSet<ChannelResource> Read(ReadChannelOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<ChannelResource>.FromJson("channels", response.Content);
            return new ResourceSet<ChannelResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Channel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Channel </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<ChannelResource>> ReadAsync(ReadChannelOptions options, 
                                                                                                ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<ChannelResource>.FromJson("channels", response.Content);
            return new ResourceSet<ChannelResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="type"> The type </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Channel </returns> 
        public static ResourceSet<ChannelResource> Read(string pathServiceSid, 
                                                        List<ChannelResource.ChannelTypeEnum> type = null, 
                                                        int? pageSize = null, 
                                                        long? limit = null, 
                                                        ITwilioRestClient client = null)
        {
            var options = new ReadChannelOptions(pathServiceSid){Type = type, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="type"> The type </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Channel </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<ChannelResource>> ReadAsync(string pathServiceSid, 
                                                                                                List<ChannelResource.ChannelTypeEnum> type = null, 
                                                                                                int? pageSize = null, 
                                                                                                long? limit = null, 
                                                                                                ITwilioRestClient client = null)
        {
            var options = new ReadChannelOptions(pathServiceSid){Type = type, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns> 
        public static Page<ChannelResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<ChannelResource>.FromJson("channels", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<ChannelResource> NextPage(Page<ChannelResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Chat,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<ChannelResource>.FromJson("channels", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<ChannelResource> PreviousPage(Page<ChannelResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Chat,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<ChannelResource>.FromJson("channels", response.Content);
        }

        private static Request BuildUpdateRequest(UpdateChannelOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Chat,
                "/v2/Services/" + options.PathServiceSid + "/Channels/" + options.PathSid + "",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update Channel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Channel </returns> 
        public static ChannelResource Update(UpdateChannelOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update Channel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Channel </returns> 
        public static async System.Threading.Tasks.Task<ChannelResource> UpdateAsync(UpdateChannelOptions options, 
                                                                                     ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="friendlyName"> A human-readable name for the Channel. </param>
        /// <param name="uniqueName"> A unique, addressable name for the Channel. </param>
        /// <param name="attributes"> An optional metadata field you can use to store any data you wish. </param>
        /// <param name="dateCreated"> The optional ISO8601 time specifying the datetime the Channel should be set as being
        ///                   created. </param>
        /// <param name="dateUpdated"> The optional ISO8601 time specifying the datetime the Channel should be set as having
        ///                   been last updated. </param>
        /// <param name="createdBy"> Optional field to specify the Identity of the User that created the Channel. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Channel </returns> 
        public static ChannelResource Update(string pathServiceSid, 
                                             string pathSid, 
                                             string friendlyName = null, 
                                             string uniqueName = null, 
                                             string attributes = null, 
                                             DateTime? dateCreated = null, 
                                             DateTime? dateUpdated = null, 
                                             string createdBy = null, 
                                             ITwilioRestClient client = null)
        {
            var options = new UpdateChannelOptions(pathServiceSid, pathSid){FriendlyName = friendlyName, UniqueName = uniqueName, Attributes = attributes, DateCreated = dateCreated, DateUpdated = dateUpdated, CreatedBy = createdBy};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="friendlyName"> A human-readable name for the Channel. </param>
        /// <param name="uniqueName"> A unique, addressable name for the Channel. </param>
        /// <param name="attributes"> An optional metadata field you can use to store any data you wish. </param>
        /// <param name="dateCreated"> The optional ISO8601 time specifying the datetime the Channel should be set as being
        ///                   created. </param>
        /// <param name="dateUpdated"> The optional ISO8601 time specifying the datetime the Channel should be set as having
        ///                   been last updated. </param>
        /// <param name="createdBy"> Optional field to specify the Identity of the User that created the Channel. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Channel </returns> 
        public static async System.Threading.Tasks.Task<ChannelResource> UpdateAsync(string pathServiceSid, 
                                                                                     string pathSid, 
                                                                                     string friendlyName = null, 
                                                                                     string uniqueName = null, 
                                                                                     string attributes = null, 
                                                                                     DateTime? dateCreated = null, 
                                                                                     DateTime? dateUpdated = null, 
                                                                                     string createdBy = null, 
                                                                                     ITwilioRestClient client = null)
        {
            var options = new UpdateChannelOptions(pathServiceSid, pathSid){FriendlyName = friendlyName, UniqueName = uniqueName, Attributes = attributes, DateCreated = dateCreated, DateUpdated = dateUpdated, CreatedBy = createdBy};
            return await UpdateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a ChannelResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ChannelResource object represented by the provided JSON </returns> 
        public static ChannelResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<ChannelResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// A 34 character string that uniquely identifies this resource.
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The unique id of the Account responsible for this channel.
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The unique id of the Service this channel belongs to.
        /// </summary>
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }
        /// <summary>
        /// The human-readable name of this channel.
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// The unique, addressable name of this channel.
        /// </summary>
        [JsonProperty("unique_name")]
        public string UniqueName { get; private set; }
        /// <summary>
        /// An optional string metadata field you can use to store any data you wish.
        /// </summary>
        [JsonProperty("attributes")]
        public string Attributes { get; private set; }
        /// <summary>
        /// The visibility of this channel - either public or private
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ChannelResource.ChannelTypeEnum Type { get; private set; }
        /// <summary>
        /// The date that this resource was created.
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date that this resource was last updated.
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// Identity of the channel's creator.
        /// </summary>
        [JsonProperty("created_by")]
        public string CreatedBy { get; private set; }
        /// <summary>
        /// The number of Members in the Channel
        /// </summary>
        [JsonProperty("members_count")]
        public int? MembersCount { get; private set; }
        /// <summary>
        /// The number of Messages in the Channel
        /// </summary>
        [JsonProperty("messages_count")]
        public int? MessagesCount { get; private set; }
        /// <summary>
        /// An absolute URL for this channel.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// Absolute URLs to access the Members, Messages , Invites and, if it exists the last Message for this Channel.
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }

        private ChannelResource()
        {

        }
    }

}