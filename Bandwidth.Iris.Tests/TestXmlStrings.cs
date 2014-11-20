﻿namespace Bandwidth.Iris.Tests
{
    public static class TestXmlStrings
    {
        public static string LocalAreaSearchResultXml = "<SearchResult><ResultCount>2</ResultCount><TelephoneNumberDetailList><TelephoneNumberDetail><City>JERSEY CITY</City><LATA>224</LATA><RateCenter>JERSEYCITY</RateCenter><State>NJ</State><TelephoneNumber>2012001555</TelephoneNumber></TelephoneNumberDetail><TelephoneNumberDetail><City>JERSEY CITY</City><LATA>224</LATA><RateCenter>JERSEYCITY</RateCenter><State>NJ</State><TelephoneNumber>123123123</TelephoneNumber></TelephoneNumberDetail></TelephoneNumberDetailList></SearchResult>";

        /**
         * Sites Xmls
         */
        public static string ValidSitesResponseXml = "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?><SitesResponse><Sites><Site><Id>1</Id><Name>Test Site</Name><Description>A site description</Description></Site></Sites></SitesResponse>";
        public static string ValidSiteResponseXml = "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?><SiteResponse><Site><Id>1</Id><Name>Test Site</Name><Description>A Site Description</Description><Address><HouseNumber>900</HouseNumber><StreetName>Main Campus Drive</StreetName><City>Raleigh</City><StateCode>NC</StateCode><Zip>27615</Zip><Country>United States</Country><AddressType>Service</AddressType></Address></Site></SiteResponse>";

        /**
         * Sip Peer Xmls
         */
        public static string ValidSipPeersResponseXml = "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?><TNSipPeersResponse><SipPeers><SipPeer xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xsi:type=\"SipPeer\"><PeerId>12345</PeerId><PeerName>SIP Peer 1</PeerName><Description>Sip Peer 1 description</Description><IsDefaultPeer>true</IsDefaultPeer><ShortMessagingProtocol>SIP</ShortMessagingProtocol><VoiceHosts><Host><HostName>70.62.112.156</HostName></Host></VoiceHosts><VoiceHostGroups/><SmsHosts><Host><HostName>70.62.112.156</HostName></Host></SmsHosts><TerminationHosts><TerminationHost><HostName>70.62.112.156</HostName><Port>5060</Port><CustomerTrafficAllowed>DOMESTIC</CustomerTrafficAllowed><DataAllowed>true</DataAllowed></TerminationHost></TerminationHosts><CallingName><Display>true</Display><Enforced>false</Enforced></CallingName></SipPeer></SipPeers></TNSipPeersResponse>";
        public static string ValidSipPeerResponseXml = "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?><SipPeerResponse><SipPeer><PeerId>10</PeerId><PeerName>SIP Peer 1</PeerName><Description>Sip Peer 1 description</Description><IsDefaultPeer>true</IsDefaultPeer><ShortMessagingProtocol>SIP</ShortMessagingProtocol><VoiceHosts/><VoiceHostGroups/><SmsHosts/><TerminationHosts/><CallingName><Display>true</Display><Enforced>false</Enforced></CallingName></SipPeer></SipPeerResponse>";
        public static string ValidSipPeerTnResponseXml = "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?><SipPeerTelephoneNumberResponse><SipPeerTelephoneNumber><FullNumber>9195551212</FullNumber></SipPeerTelephoneNumber></SipPeerTelephoneNumberResponse>";
        public static string ValidSipPeerTnsResponseXml = "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?><SipPeerTelephoneNumbersResponse><SipPeerTelephoneNumbers><SipPeerTelephoneNumber><FullNumber>3034162216</FullNumber></SipPeerTelephoneNumber><SipPeerTelephoneNumber><FullNumber>3034162218</FullNumber></SipPeerTelephoneNumber><SipPeerTelephoneNumber><FullNumber>3034162227</FullNumber></SipPeerTelephoneNumber><SipPeerTelephoneNumber><FullNumber>7025097265</FullNumber></SipPeerTelephoneNumber><SipPeerTelephoneNumber><FullNumber>3034162212</FullNumber></SipPeerTelephoneNumber><SipPeerTelephoneNumber><FullNumber>7024759964</FullNumber></SipPeerTelephoneNumber><SipPeerTelephoneNumber><FullNumber>3034162226</FullNumber></SipPeerTelephoneNumber><SipPeerTelephoneNumber><FullNumber>3034162231</FullNumber></SipPeerTelephoneNumber><SipPeerTelephoneNumber><FullNumber>3034162223</FullNumber></SipPeerTelephoneNumber><SipPeerTelephoneNumber><FullNumber>2143770078</FullNumber></SipPeerTelephoneNumber><SipPeerTelephoneNumber><FullNumber>3302699968</FullNumber></SipPeerTelephoneNumber><SipPeerTelephoneNumber><FullNumber>8665711365</FullNumber></SipPeerTelephoneNumber><SipPeerTelephoneNumber><FullNumber>9284448929</FullNumber></SipPeerTelephoneNumber><SipPeerTelephoneNumber><FullNumber>3302710174</FullNumber></SipPeerTelephoneNumber><SipPeerTelephoneNumber><FullNumber>7024797571</FullNumber></SipPeerTelephoneNumber><SipPeerTelephoneNumber><FullNumber>7025091999</FullNumber></SipPeerTelephoneNumber><SipPeerTelephoneNumber><FullNumber>7022579119</FullNumber></SipPeerTelephoneNumber></SipPeerTelephoneNumbers></SipPeerTelephoneNumbersResponse>"; 
        /**
         * Order Xmls
         */
        public static string ValidOrderResponseXml = "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?><OrderResponse><Order><Name>A New Order</Name><OrderCreateDate>2014-10-14T17:58:15.299Z</OrderCreateDate><BackOrderRequested>false</BackOrderRequested><id>1</id><ExistingTelephoneNumberOrderType><TelephoneNumberList><TelephoneNumber>2052865046</TelephoneNumber></TelephoneNumberList></ExistingTelephoneNumberOrderType><PartialAllowed>false</PartialAllowed><SiteId>2858</SiteId></Order></OrderResponse>";

        /**
         * Reservation Xmls
         */

        public static string ValidReservationResponseXml = "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?><ReservationResponse><Reservation><ReservationId>1</ReservationId><AccountId>accountId</AccountId><ReservationExpires>30</ReservationExpires><ReservedTn>9195551212</ReservedTn></Reservation></ReservationResponse>";
        public static string InvalidReservationResponseXml = "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?><ReservationResponse><ResponseStatus><ErrorCode>5041</ErrorCode><Description>Reservation failed: telephone number 9195551212 is not available.</Description></ResponseStatus></ReservationResponse>";
        public static string ValidCreatePostInResponse = "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?><LnpOrderResponse><OrderId>d28b36f7-fa96-49eb-9556-a40fca49f7c6</OrderId><Status><Code>201</Code><Description>Order request received. Please use the order id to check the status of your order later.</Description></Status><ProcessingStatus>PENDING_DOCUMENTS</ProcessingStatus><LoaAuthorizingPerson>John Doe</LoaAuthorizingPerson><Subscriber><SubscriberType>BUSINESS</SubscriberType><BusinessName>Acme Corporation</BusinessName><ServiceAddress><HouseNumber>1623</HouseNumber><StreetName>Brockton Ave #1</StreetName><City>Los Angeles</City><StateCode>CA</StateCode><Zip>90025</Zip><Country>USA</Country></ServiceAddress></Subscriber><BillingTelephoneNumber>6882015002</BillingTelephoneNumber><ListOfPhoneNumbers><PhoneNumber>6882015025</PhoneNumber><PhoneNumber>6882015026</PhoneNumber></ListOfPhoneNumbers><Triggered>false</Triggered><BillingType>PORTIN</BillingType></LnpOrderResponse>";


        public static string FileListResponse = "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?><fileListResponse><fileCount>6</fileCount><fileData><FileName>d28b36f7-fa96-49eb-9556-a40fca49f7c6-1416231534986.txt</FileName><FileMetaData><DocumentType>LOA</DocumentType></FileMetaData></fileData><fileData><FileName>d28b36f7-fa96-49eb-9556-a40fca49f7c6-1416231558768.txt</FileName><FileMetaData><DocumentType>LOA</DocumentType></FileMetaData></fileData><fileData><FileName>d28b36f7-fa96-49eb-9556-a40fca49f7c6-1416231581134.txt</FileName><FileMetaData><DocumentType>LOA</DocumentType></FileMetaData></fileData><fileData><FileName>d28b36f7-fa96-49eb-9556-a40fca49f7c6-1416231629005.txt</FileName><FileMetaData><DocumentType>LOA</DocumentType></FileMetaData></fileData><fileData><FileName>d28b36f7-fa96-49eb-9556-a40fca49f7c6-1416231699462.txt</FileName><FileMetaData><DocumentType>LOA</DocumentType></FileMetaData></fileData><fileData><FileName>d28b36f7-fa96-49eb-9556-a40fca49f7c6-1416232756923.txt</FileName><FileMetaData><DocumentType>LOA</DocumentType></FileMetaData></fileData><resultCode>0</resultCode><resultMessage>LOA file list successfully returned</resultMessage></fileListResponse>";
        public static string FileMetadataResponse = "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?><FileMetaData><DocumentType>LOA</DocumentType></FileMetaData>";

        public static string LnpCheckResponse = "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?><NumberPortabilityResponse><PortableNumbers><Tn>9195551212</Tn><Tn>9195551213</Tn></PortableNumbers><SupportedRateCenters><RateCenterGroup><RateCenter>RALEIGH</RateCenter><City>RALEIGH</City><State>NC</State><LATA>426</LATA><Tiers><Tier>0</Tier></Tiers><TnList><Tn>9195551212</Tn><Tn>9195551213</Tn></TnList></RateCenterGroup></SupportedRateCenters><UnsupportedRateCenters/><SupportedLosingCarriers><LosingCarrierTnList><LosingCarrierSPID>6214</LosingCarrierSPID><LosingCarrierName>Cingular</LosingCarrierName><TnList><Tn>9195551212</Tn><Tn>9195551213</Tn></TnList></LosingCarrierTnList></SupportedLosingCarriers><UnsupportedLosingCarriers/></NumberPortabilityResponse>";
        public static string NotesResponse = "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?><Notes><Note><Id>11299</Id><UserId>customer</UserId><Description>Test</Description><LastDateModifier>2014-11-20T07:08:47.000Z</LastDateModifier></Note><Note><Id>11301</Id><UserId>customer</UserId><Description>Test1</Description><LastDateModifier>2014-11-20T07:11:36.000Z</LastDateModifier></Note></Notes>";
        public static string SubscriptionResponse = "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?><SubscriptionsResponse><Subscriptions><Subscription><SubscriptionId>1</SubscriptionId><OrderType>orders</OrderType><OrderId>8684b1c8-7d41-4877-bfc2-6bd8ea4dc89f</OrderId><EmailSubscription><Email>test@test</Email><DigestRequested>NONE</DigestRequested></EmailSubscription></Subscription></Subscriptions></SubscriptionsResponse>";
    }
}
