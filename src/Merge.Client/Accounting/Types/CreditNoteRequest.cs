using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Accounting;

/// <summary>
/// # The CreditNote Object
/// ### Description
/// A `CreditNote` is transaction issued to a customer, indicating a reduction or cancellation of the amount owed by the customer. It is most generally used as an adjustment note used to rectify errors, returns, or overpayments related to a sales transaction. A `CreditNote` can be applied to *Accounts Receivable* Invoices to decrease the overall amount of the Invoice.
///
/// ### Usage Example
/// Fetch from the `LIST CreditNotes` endpoint and view a company's credit notes.
/// </summary>
[Serializable]
public record CreditNoteRequest
{
    /// <summary>
    /// The credit note's transaction date.
    /// </summary>
    [JsonPropertyName("transaction_date")]
    public DateTime? TransactionDate { get; set; }

    /// <summary>
    /// The credit note's status.
    ///
    /// * `SUBMITTED` - SUBMITTED
    /// * `AUTHORIZED` - AUTHORIZED
    /// * `PAID` - PAID
    /// </summary>
    [JsonPropertyName("status")]
    public OneOf<CreditNoteStatusEnum, string>? Status { get; set; }

    /// <summary>
    /// The credit note's number.
    /// </summary>
    [JsonPropertyName("number")]
    public string? Number { get; set; }

    /// <summary>
    /// The credit note's contact.
    /// </summary>
    [JsonPropertyName("contact")]
    public OneOf<string, Contact>? Contact { get; set; }

    /// <summary>
    /// The company the credit note belongs to.
    /// </summary>
    [JsonPropertyName("company")]
    public OneOf<string, CompanyInfo>? Company { get; set; }

    /// <summary>
    /// The credit note's exchange rate.
    /// </summary>
    [JsonPropertyName("exchange_rate")]
    public string? ExchangeRate { get; set; }

    /// <summary>
    /// The credit note's total amount.
    /// </summary>
    [JsonPropertyName("total_amount")]
    public double? TotalAmount { get; set; }

    /// <summary>
    /// The amount of value remaining in the credit note that the customer can use.
    /// </summary>
    [JsonPropertyName("remaining_credit")]
    public double? RemainingCredit { get; set; }

    /// <summary>
    /// If the transaction is inclusive or exclusive of tax. `True` if inclusive, `False` if exclusive.
    /// </summary>
    [JsonPropertyName("inclusive_of_tax")]
    public bool? InclusiveOfTax { get; set; }

    [JsonPropertyName("line_items")]
    public IEnumerable<OneOf<string, CreditNoteLineItemRequest>>? LineItems { get; set; }

    [JsonPropertyName("tracking_categories")]
    public IEnumerable<OneOf<string, TrackingCategory>>? TrackingCategories { get; set; }

    /// <summary>
    /// The credit note's currency.
    ///
    /// * `XUA` - ADB Unit of Account
    /// * `AFN` - Afghan Afghani
    /// * `AFA` - Afghan Afghani (1927–2002)
    /// * `ALL` - Albanian Lek
    /// * `ALK` - Albanian Lek (1946–1965)
    /// * `DZD` - Algerian Dinar
    /// * `ADP` - Andorran Peseta
    /// * `AOA` - Angolan Kwanza
    /// * `AOK` - Angolan Kwanza (1977–1991)
    /// * `AON` - Angolan New Kwanza (1990–2000)
    /// * `AOR` - Angolan Readjusted Kwanza (1995–1999)
    /// * `ARA` - Argentine Austral
    /// * `ARS` - Argentine Peso
    /// * `ARM` - Argentine Peso (1881–1970)
    /// * `ARP` - Argentine Peso (1983–1985)
    /// * `ARL` - Argentine Peso Ley (1970–1983)
    /// * `AMD` - Armenian Dram
    /// * `AWG` - Aruban Florin
    /// * `AUD` - Australian Dollar
    /// * `ATS` - Austrian Schilling
    /// * `AZN` - Azerbaijani Manat
    /// * `AZM` - Azerbaijani Manat (1993–2006)
    /// * `BSD` - Bahamian Dollar
    /// * `BHD` - Bahraini Dinar
    /// * `BDT` - Bangladeshi Taka
    /// * `BBD` - Barbadian Dollar
    /// * `BYN` - Belarusian Ruble
    /// * `BYB` - Belarusian Ruble (1994–1999)
    /// * `BYR` - Belarusian Ruble (2000–2016)
    /// * `BEF` - Belgian Franc
    /// * `BEC` - Belgian Franc (convertible)
    /// * `BEL` - Belgian Franc (financial)
    /// * `BZD` - Belize Dollar
    /// * `BMD` - Bermudan Dollar
    /// * `BTN` - Bhutanese Ngultrum
    /// * `BOB` - Bolivian Boliviano
    /// * `BOL` - Bolivian Boliviano (1863–1963)
    /// * `BOV` - Bolivian Mvdol
    /// * `BOP` - Bolivian Peso
    /// * `BAM` - Bosnia-Herzegovina Convertible Mark
    /// * `BAD` - Bosnia-Herzegovina Dinar (1992–1994)
    /// * `BAN` - Bosnia-Herzegovina New Dinar (1994–1997)
    /// * `BWP` - Botswanan Pula
    /// * `BRC` - Brazilian Cruzado (1986–1989)
    /// * `BRZ` - Brazilian Cruzeiro (1942–1967)
    /// * `BRE` - Brazilian Cruzeiro (1990–1993)
    /// * `BRR` - Brazilian Cruzeiro (1993–1994)
    /// * `BRN` - Brazilian New Cruzado (1989–1990)
    /// * `BRB` - Brazilian New Cruzeiro (1967–1986)
    /// * `BRL` - Brazilian Real
    /// * `GBP` - British Pound
    /// * `BND` - Brunei Dollar
    /// * `BGL` - Bulgarian Hard Lev
    /// * `BGN` - Bulgarian Lev
    /// * `BGO` - Bulgarian Lev (1879–1952)
    /// * `BGM` - Bulgarian Socialist Lev
    /// * `BUK` - Burmese Kyat
    /// * `BIF` - Burundian Franc
    /// * `XPF` - CFP Franc
    /// * `KHR` - Cambodian Riel
    /// * `CAD` - Canadian Dollar
    /// * `CVE` - Cape Verdean Escudo
    /// * `KYD` - Cayman Islands Dollar
    /// * `XAF` - Central African CFA Franc
    /// * `CLE` - Chilean Escudo
    /// * `CLP` - Chilean Peso
    /// * `CLF` - Chilean Unit of Account (UF)
    /// * `CNX` - Chinese People’s Bank Dollar
    /// * `CNY` - Chinese Yuan
    /// * `CNH` - Chinese Yuan (offshore)
    /// * `COP` - Colombian Peso
    /// * `COU` - Colombian Real Value Unit
    /// * `KMF` - Comorian Franc
    /// * `CDF` - Congolese Franc
    /// * `CRC` - Costa Rican Colón
    /// * `HRD` - Croatian Dinar
    /// * `HRK` - Croatian Kuna
    /// * `CUC` - Cuban Convertible Peso
    /// * `CUP` - Cuban Peso
    /// * `CYP` - Cypriot Pound
    /// * `CZK` - Czech Koruna
    /// * `CSK` - Czechoslovak Hard Koruna
    /// * `DKK` - Danish Krone
    /// * `DJF` - Djiboutian Franc
    /// * `DOP` - Dominican Peso
    /// * `NLG` - Dutch Guilder
    /// * `XCD` - East Caribbean Dollar
    /// * `DDM` - East German Mark
    /// * `ECS` - Ecuadorian Sucre
    /// * `ECV` - Ecuadorian Unit of Constant Value
    /// * `EGP` - Egyptian Pound
    /// * `GQE` - Equatorial Guinean Ekwele
    /// * `ERN` - Eritrean Nakfa
    /// * `EEK` - Estonian Kroon
    /// * `ETB` - Ethiopian Birr
    /// * `EUR` - Euro
    /// * `XBA` - European Composite Unit
    /// * `XEU` - European Currency Unit
    /// * `XBB` - European Monetary Unit
    /// * `XBC` - European Unit of Account (XBC)
    /// * `XBD` - European Unit of Account (XBD)
    /// * `FKP` - Falkland Islands Pound
    /// * `FJD` - Fijian Dollar
    /// * `FIM` - Finnish Markka
    /// * `FRF` - French Franc
    /// * `XFO` - French Gold Franc
    /// * `XFU` - French UIC-Franc
    /// * `GMD` - Gambian Dalasi
    /// * `GEK` - Georgian Kupon Larit
    /// * `GEL` - Georgian Lari
    /// * `DEM` - German Mark
    /// * `GHS` - Ghanaian Cedi
    /// * `GHC` - Ghanaian Cedi (1979–2007)
    /// * `GIP` - Gibraltar Pound
    /// * `XAU` - Gold
    /// * `GRD` - Greek Drachma
    /// * `GTQ` - Guatemalan Quetzal
    /// * `GWP` - Guinea-Bissau Peso
    /// * `GNF` - Guinean Franc
    /// * `GNS` - Guinean Syli
    /// * `GYD` - Guyanaese Dollar
    /// * `HTG` - Haitian Gourde
    /// * `HNL` - Honduran Lempira
    /// * `HKD` - Hong Kong Dollar
    /// * `HUF` - Hungarian Forint
    /// * `IMP` - IMP
    /// * `ISK` - Icelandic Króna
    /// * `ISJ` - Icelandic Króna (1918–1981)
    /// * `INR` - Indian Rupee
    /// * `IDR` - Indonesian Rupiah
    /// * `IRR` - Iranian Rial
    /// * `IQD` - Iraqi Dinar
    /// * `IEP` - Irish Pound
    /// * `ILS` - Israeli New Shekel
    /// * `ILP` - Israeli Pound
    /// * `ILR` - Israeli Shekel (1980–1985)
    /// * `ITL` - Italian Lira
    /// * `JMD` - Jamaican Dollar
    /// * `JPY` - Japanese Yen
    /// * `JOD` - Jordanian Dinar
    /// * `KZT` - Kazakhstani Tenge
    /// * `KES` - Kenyan Shilling
    /// * `KWD` - Kuwaiti Dinar
    /// * `KGS` - Kyrgystani Som
    /// * `LAK` - Laotian Kip
    /// * `LVL` - Latvian Lats
    /// * `LVR` - Latvian Ruble
    /// * `LBP` - Lebanese Pound
    /// * `LSL` - Lesotho Loti
    /// * `LRD` - Liberian Dollar
    /// * `LYD` - Libyan Dinar
    /// * `LTL` - Lithuanian Litas
    /// * `LTT` - Lithuanian Talonas
    /// * `LUL` - Luxembourg Financial Franc
    /// * `LUC` - Luxembourgian Convertible Franc
    /// * `LUF` - Luxembourgian Franc
    /// * `MOP` - Macanese Pataca
    /// * `MKD` - Macedonian Denar
    /// * `MKN` - Macedonian Denar (1992–1993)
    /// * `MGA` - Malagasy Ariary
    /// * `MGF` - Malagasy Franc
    /// * `MWK` - Malawian Kwacha
    /// * `MYR` - Malaysian Ringgit
    /// * `MVR` - Maldivian Rufiyaa
    /// * `MVP` - Maldivian Rupee (1947–1981)
    /// * `MLF` - Malian Franc
    /// * `MTL` - Maltese Lira
    /// * `MTP` - Maltese Pound
    /// * `MRU` - Mauritanian Ouguiya
    /// * `MRO` - Mauritanian Ouguiya (1973–2017)
    /// * `MUR` - Mauritian Rupee
    /// * `MXV` - Mexican Investment Unit
    /// * `MXN` - Mexican Peso
    /// * `MXP` - Mexican Silver Peso (1861–1992)
    /// * `MDC` - Moldovan Cupon
    /// * `MDL` - Moldovan Leu
    /// * `MCF` - Monegasque Franc
    /// * `MNT` - Mongolian Tugrik
    /// * `MAD` - Moroccan Dirham
    /// * `MAF` - Moroccan Franc
    /// * `MZE` - Mozambican Escudo
    /// * `MZN` - Mozambican Metical
    /// * `MZM` - Mozambican Metical (1980–2006)
    /// * `MMK` - Myanmar Kyat
    /// * `NAD` - Namibian Dollar
    /// * `NPR` - Nepalese Rupee
    /// * `ANG` - Netherlands Antillean Guilder
    /// * `TWD` - New Taiwan Dollar
    /// * `NZD` - New Zealand Dollar
    /// * `NIO` - Nicaraguan Córdoba
    /// * `NIC` - Nicaraguan Córdoba (1988–1991)
    /// * `NGN` - Nigerian Naira
    /// * `KPW` - North Korean Won
    /// * `NOK` - Norwegian Krone
    /// * `OMR` - Omani Rial
    /// * `PKR` - Pakistani Rupee
    /// * `XPD` - Palladium
    /// * `PAB` - Panamanian Balboa
    /// * `PGK` - Papua New Guinean Kina
    /// * `PYG` - Paraguayan Guarani
    /// * `PEI` - Peruvian Inti
    /// * `PEN` - Peruvian Sol
    /// * `PES` - Peruvian Sol (1863–1965)
    /// * `PHP` - Philippine Peso
    /// * `XPT` - Platinum
    /// * `PLN` - Polish Zloty
    /// * `PLZ` - Polish Zloty (1950–1995)
    /// * `PTE` - Portuguese Escudo
    /// * `GWE` - Portuguese Guinea Escudo
    /// * `QAR` - Qatari Rial
    /// * `XRE` - RINET Funds
    /// * `RHD` - Rhodesian Dollar
    /// * `RON` - Romanian Leu
    /// * `ROL` - Romanian Leu (1952–2006)
    /// * `RUB` - Russian Ruble
    /// * `RUR` - Russian Ruble (1991–1998)
    /// * `RWF` - Rwandan Franc
    /// * `SVC` - Salvadoran Colón
    /// * `WST` - Samoan Tala
    /// * `SAR` - Saudi Riyal
    /// * `RSD` - Serbian Dinar
    /// * `CSD` - Serbian Dinar (2002–2006)
    /// * `SCR` - Seychellois Rupee
    /// * `SLL` - Sierra Leonean Leone
    /// * `XAG` - Silver
    /// * `SGD` - Singapore Dollar
    /// * `SKK` - Slovak Koruna
    /// * `SIT` - Slovenian Tolar
    /// * `SBD` - Solomon Islands Dollar
    /// * `SOS` - Somali Shilling
    /// * `ZAR` - South African Rand
    /// * `ZAL` - South African Rand (financial)
    /// * `KRH` - South Korean Hwan (1953–1962)
    /// * `KRW` - South Korean Won
    /// * `KRO` - South Korean Won (1945–1953)
    /// * `SSP` - South Sudanese Pound
    /// * `SUR` - Soviet Rouble
    /// * `ESP` - Spanish Peseta
    /// * `ESA` - Spanish Peseta (A account)
    /// * `ESB` - Spanish Peseta (convertible account)
    /// * `XDR` - Special Drawing Rights
    /// * `LKR` - Sri Lankan Rupee
    /// * `SHP` - St. Helena Pound
    /// * `XSU` - Sucre
    /// * `SDD` - Sudanese Dinar (1992–2007)
    /// * `SDG` - Sudanese Pound
    /// * `SDP` - Sudanese Pound (1957–1998)
    /// * `SRD` - Surinamese Dollar
    /// * `SRG` - Surinamese Guilder
    /// * `SZL` - Swazi Lilangeni
    /// * `SEK` - Swedish Krona
    /// * `CHF` - Swiss Franc
    /// * `SYP` - Syrian Pound
    /// * `STN` - São Tomé & Príncipe Dobra
    /// * `STD` - São Tomé & Príncipe Dobra (1977–2017)
    /// * `TVD` - TVD
    /// * `TJR` - Tajikistani Ruble
    /// * `TJS` - Tajikistani Somoni
    /// * `TZS` - Tanzanian Shilling
    /// * `XTS` - Testing Currency Code
    /// * `THB` - Thai Baht
    /// * `XXX` - The codes assigned for transactions where no currency is involved
    /// * `TPE` - Timorese Escudo
    /// * `TOP` - Tongan Paʻanga
    /// * `TTD` - Trinidad & Tobago Dollar
    /// * `TND` - Tunisian Dinar
    /// * `TRY` - Turkish Lira
    /// * `TRL` - Turkish Lira (1922–2005)
    /// * `TMT` - Turkmenistani Manat
    /// * `TMM` - Turkmenistani Manat (1993–2009)
    /// * `USD` - US Dollar
    /// * `USN` - US Dollar (Next day)
    /// * `USS` - US Dollar (Same day)
    /// * `UGX` - Ugandan Shilling
    /// * `UGS` - Ugandan Shilling (1966–1987)
    /// * `UAH` - Ukrainian Hryvnia
    /// * `UAK` - Ukrainian Karbovanets
    /// * `AED` - United Arab Emirates Dirham
    /// * `UYW` - Uruguayan Nominal Wage Index Unit
    /// * `UYU` - Uruguayan Peso
    /// * `UYP` - Uruguayan Peso (1975–1993)
    /// * `UYI` - Uruguayan Peso (Indexed Units)
    /// * `UZS` - Uzbekistani Som
    /// * `VUV` - Vanuatu Vatu
    /// * `VES` - Venezuelan Bolívar
    /// * `VEB` - Venezuelan Bolívar (1871–2008)
    /// * `VEF` - Venezuelan Bolívar (2008–2018)
    /// * `VND` - Vietnamese Dong
    /// * `VNN` - Vietnamese Dong (1978–1985)
    /// * `CHE` - WIR Euro
    /// * `CHW` - WIR Franc
    /// * `XOF` - West African CFA Franc
    /// * `YDD` - Yemeni Dinar
    /// * `YER` - Yemeni Rial
    /// * `YUN` - Yugoslavian Convertible Dinar (1990–1992)
    /// * `YUD` - Yugoslavian Hard Dinar (1966–1990)
    /// * `YUM` - Yugoslavian New Dinar (1994–2002)
    /// * `YUR` - Yugoslavian Reformed Dinar (1992–1993)
    /// * `ZWN` - ZWN
    /// * `ZRN` - Zairean New Zaire (1993–1998)
    /// * `ZRZ` - Zairean Zaire (1971–1993)
    /// * `ZMW` - Zambian Kwacha
    /// * `ZMK` - Zambian Kwacha (1968–2012)
    /// * `ZWD` - Zimbabwean Dollar (1980–2008)
    /// * `ZWR` - Zimbabwean Dollar (2008)
    /// * `ZWL` - Zimbabwean Dollar (2009)
    /// </summary>
    [JsonPropertyName("currency")]
    public OneOf<TransactionCurrencyEnum, string>? Currency { get; set; }

    /// <summary>
    /// Array of `Payment` object IDs
    /// </summary>
    [JsonPropertyName("payments")]
    public IEnumerable<OneOf<string, Payment>>? Payments { get; set; }

    /// <summary>
    /// A list of the Payment Applied to Lines common models related to a given Invoice, Credit Note, or Journal Entry.
    /// </summary>
    [JsonPropertyName("applied_payments")]
    public IEnumerable<OneOf<string, PaymentLineItem>>? AppliedPayments { get; set; }

    /// <summary>
    /// The accounting period that the CreditNote was generated in.
    /// </summary>
    [JsonPropertyName("accounting_period")]
    public OneOf<string, AccountingPeriod>? AccountingPeriod { get; set; }

    /// <summary>
    /// A list of the CreditNote Applied to Lines common models related to a given Credit Note
    /// </summary>
    [JsonPropertyName("applied_to_lines")]
    public IEnumerable<CreditNoteApplyLineForCreditNoteRequest>? AppliedToLines { get; set; }

    [JsonAccess(JsonAccessType.WriteOnly)]
    [JsonPropertyName("integration_params")]
    public Dictionary<string, object?>? IntegrationParams { get; set; }

    [JsonAccess(JsonAccessType.WriteOnly)]
    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object?>? LinkedAccountParams { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
