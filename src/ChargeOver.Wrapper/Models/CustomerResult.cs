using System;
using Newtonsoft.Json;

namespace  ChargeOver.Wrapper.Models
{
	public sealed class CustomerResult
	{
		/// <summary>
		/// Customer ID #
		/// </summary>
		[JsonProperty("customer_id")]
		public int? CustomerId { get; set; }
		/// <summary>
		/// Customer Token
		/// </summary>
		[JsonProperty("token")]
		public string Token { get; set; }
		/// <summary>
		/// Main contact ID #
		/// </summary>
		[JsonProperty("superuser_id")]
		public int? SuperuserId { get; set; }
		/// <summary>
		/// External key value
		/// </summary>
		[JsonProperty("external_key")]
		public string ExternalKey { get; set; }
		/// <summary>
		/// Deprecated
		/// </summary>
		[JsonProperty("display_as")]
		public string DisplayAs { get; set; }
		/// <summary>
		/// Company/customer name
		/// </summary>
		[JsonProperty("company")]
		public string Company { get; set; }
		/// <summary>
		/// Language ID #
		/// </summary>
		[JsonProperty("language_id")]
		public int? LanguageId { get; set; }
		/// <summary>
		/// Currency ID #
		/// </summary>
		[JsonProperty("currency_id")]
		public int? CurrencyId { get; set; }
		/// <summary>
		/// ISO 4217 currency code representation
		/// </summary>
		[JsonProperty("currency_iso4217")]
		public string CurrencyIso4217 { get; set; }
		/// <summary>
		/// Symbol for currency ($, Â£, etc.)
		/// </summary>
		[JsonProperty("currency_symbol")]
		public string CurrencySymbol { get; set; }
		/// <summary>
		/// Default terms ID #
		/// </summary>
		[JsonProperty("terms_id")]
		public int? TermsId { get; set; }
		/// <summary>
		/// Default class tracking ID #
		/// </summary>
		[JsonProperty("class_id")]
		public int? ClassId { get; set; }
		/// <summary>
		/// Admin/Worker ID #
		/// </summary>
		[JsonProperty("admin_id")]
		public int? AdminId { get; set; }
		/// <summary>
		/// Campaign/lead source ID #
		/// </summary>
		[JsonProperty("campaign_id")]
		public int? CampaignId { get; set; }
		/// <summary>
		/// Customer type ID #
		/// </summary>
		[JsonProperty("custtype_id")]
		public int? CusttypeId { get; set; }
		/// <summary>
		/// Flag to disable charging of taxes
		/// </summary>
		[JsonProperty("no_taxes")]
		public bool NoTaxes { get; set; }
		/// <summary>
		/// Flag to disable dunning
		/// </summary>
		[JsonProperty("no_dunning")]
		public bool NoDunning { get; set; }
		/// <summary>
		/// Main contact username
		/// </summary>
		[JsonProperty("superuser_username")]
		public string SuperuserUsername { get; set; }
		/// <summary>
		/// Main contact e-mail address
		/// </summary>
		[JsonProperty("superuser_email")]
		public string SuperuserEmail { get; set; }
		/// <summary>
		/// Main contact name
		/// </summary>
		[JsonProperty("superuser_name")]
		public string SuperuserName { get; set; }
		/// <summary>
		/// Main contact first name
		/// </summary>
		[JsonProperty("superuser_first_name")]
		public string SuperuserFirstName { get; set; }
		/// <summary>
		/// Main contact last name
		/// </summary>
		[JsonProperty("superuser_last_name")]
		public string SuperuserLastName { get; set; }
		/// <summary>
		/// Main contact phone number
		/// </summary>
		[JsonProperty("superuser_phone")]
		public string SuperuserPhone { get; set; }
		/// <summary>
		/// Main contact token
		/// </summary>
		[JsonProperty("superuser_token")]
		public string SuperuserToken { get; set; }
		/// <summary>
		/// Billing address line 1
		/// </summary>
		[JsonProperty("bill_addr1")]
		public string BillAddr1 { get; set; }
		/// <summary>
		/// Billing address line 2
		/// </summary>
		[JsonProperty("bill_addr2")]
		public string BillAddr2 { get; set; }
		/// <summary>
		/// Billing address line 3
		/// </summary>
		[JsonProperty("bill_addr3")]
		public string BillAddr3 { get; set; }
		/// <summary>
		/// Billing address city
		/// </summary>
		[JsonProperty("bill_city")]
		public string BillCity { get; set; }
		/// <summary>
		/// Billing address state/province
		/// </summary>
		[JsonProperty("bill_state")]
		public string BillState { get; set; }
		/// <summary>
		/// Billing address postal code
		/// </summary>
		[JsonProperty("bill_postcode")]
		public string BillPostcode { get; set; }
		/// <summary>
		/// Billing address country
		/// </summary>
		[JsonProperty("bill_country")]
		public string BillCountry { get; set; }
		/// <summary>
		/// Printable billing address
		/// </summary>
		[JsonProperty("bill_block")]
		public string BillBlock { get; set; }
		/// <summary>
		/// Shipping address line 1
		/// </summary>
		[JsonProperty("ship_addr1")]
		public string ShipAddr1 { get; set; }
		/// <summary>
		/// Shipping address line 2
		/// </summary>
		[JsonProperty("ship_addr2")]
		public string ShipAddr2 { get; set; }
		/// <summary>
		/// Shipping address line 3
		/// </summary>
		[JsonProperty("ship_addr3")]
		public string ShipAddr3 { get; set; }
		/// <summary>
		/// Shipping address city
		/// </summary>
		[JsonProperty("ship_city")]
		public string ShipCity { get; set; }
		/// <summary>
		/// Shipping address state
		/// </summary>
		[JsonProperty("ship_state")]
		public string ShipState { get; set; }
		/// <summary>
		/// Shipping address postal code
		/// </summary>
		[JsonProperty("ship_postcode")]
		public string ShipPostcode { get; set; }
		/// <summary>
		/// Shipping address country
		/// </summary>
		[JsonProperty("ship_country")]
		public string ShipCountry { get; set; }
		/// <summary>
		/// Printable shipping address
		/// </summary>
		[JsonProperty("ship_block")]
		public string ShipBlock { get; set; }
		/// <summary>
		/// Custom field #1
		/// </summary>
		[JsonProperty("custom_1")]
		public string Custom1 { get; set; }
		/// <summary>
		/// Custom field #2
		/// </summary>
		[JsonProperty("custom_2")]
		public string Custom2 { get; set; }
		/// <summary>
		/// Custom field #3
		/// </summary>
		[JsonProperty("custom_3")]
		public string Custom3 { get; set; }
		/// <summary>
		/// Custom field #4
		/// </summary>
		[JsonProperty("custom_4")]
		public string Custom4 { get; set; }
		/// <summary>
		/// Custom field #5
		/// </summary>
		[JsonProperty("custom_5")]
		public string Custom5 { get; set; }
		/// <summary>
		/// Custom field #6
		/// </summary>
		[JsonProperty("custom_6")]
		public string Custom6 { get; set; }
		/// <summary>
		/// The sum total amount of all invoices ever issued to this customer
		/// </summary>
		[JsonProperty("total")]
		public float? Total { get; set; }
		/// <summary>
		/// Balance due for this customer
		/// </summary>
		[JsonProperty("balance")]
		public float? Balance { get; set; }
		/// <summary>
		/// The sum total amount of all payments ever made by this customer
		/// </summary>
		[JsonProperty("paid")]
		public float? Paid { get; set; }
		/// <summary>
		/// Date/time this customer was created
		/// </summary>
		[JsonProperty("write_datetime")]
		public string WriteDatetime { get; set; }
		/// <summary>
		/// IP address that created this customer
		/// </summary>
		[JsonProperty("write_ipaddr")]
		public string WriteIpaddr { get; set; }
		/// <summary>
		/// Date/time this customer was updated
		/// </summary>
		[JsonProperty("mod_datetime")]
		public string ModDatetime { get; set; }
		/// <summary>
		/// IP address that last updated this customer
		/// </summary>
		[JsonProperty("mod_ipaddr")]
		public string ModIpaddr { get; set; }
		/// <summary>
		/// Brand ID #
		/// </summary>
		[JsonProperty("brand_id")]
		public int? BrandId { get; set; }
		/// <summary>
		/// Default payment terms
		/// </summary>
		[JsonProperty("terms_name")]
		public string TermsName { get; set; }
		/// <summary>
		/// # of days for the default payment terms
		/// </summary>
		[JsonProperty("terms_days")]
		public int? TermsDays { get; set; }
		/// <summary>
		/// URL the customer can visit to update their payment method
		/// </summary>
		[JsonProperty("url_paymethodlink")]
		public string UrlPaymethodlink { get; set; }
		/// <summary>
		/// URL for viewing the customer in the GUI
		/// </summary>
		[JsonProperty("url_self")]
		public string UrlSelf { get; set; }
		/// <summary>
		/// Admin/Worker Name
		/// </summary>
		[JsonProperty("admin_name")]
		public string AdminName { get; set; }
		/// <summary>
		/// Admin/Worker Email
		/// </summary>
		[JsonProperty("admin_email")]
		public string AdminEmail { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("customer_status_id")]
		public string CustomerStatusId { get; set; }
		/// <summary>
		/// Human-friendly customer status
		/// </summary>
		[JsonProperty("customer_status_name")]
		public string CustomerStatusName { get; set; }
		/// <summary>
		/// Status string
		/// </summary>
		[JsonProperty("customer_status_str")]
		public string CustomerStatusStr { get; set; }
		/// <summary>
		/// Status code
		/// </summary>
		[JsonProperty("customer_status_state")]
		public string CustomerStatusState { get; set; }
		/// <summary>
		/// Delivery method for initial invoices ("email" or "print" for printed hard-copy)
		/// </summary>
		[JsonProperty("invoice_delivery")]
		public string InvoiceDelivery { get; set; }
		/// <summary>
		/// Delivery method for dunning/reminder invoices ("email" or "print" for printed hard-copy via Docsaway, Lob, etc.)
		/// </summary>
		[JsonProperty("dunning_delivery")]
		public string DunningDelivery { get; set; }
	}
}
