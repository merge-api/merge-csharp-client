using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Hris;

[JsonConverter(typeof(StringEnumSerializer<PayCurrencyEnum>))]
public readonly record struct PayCurrencyEnum : IStringEnum
{
    public static readonly PayCurrencyEnum Xua = new(Values.Xua);

    public static readonly PayCurrencyEnum Afn = new(Values.Afn);

    public static readonly PayCurrencyEnum Afa = new(Values.Afa);

    public static readonly PayCurrencyEnum All = new(Values.All);

    public static readonly PayCurrencyEnum Alk = new(Values.Alk);

    public static readonly PayCurrencyEnum Dzd = new(Values.Dzd);

    public static readonly PayCurrencyEnum Adp = new(Values.Adp);

    public static readonly PayCurrencyEnum Aoa = new(Values.Aoa);

    public static readonly PayCurrencyEnum Aok = new(Values.Aok);

    public static readonly PayCurrencyEnum Aon = new(Values.Aon);

    public static readonly PayCurrencyEnum Aor = new(Values.Aor);

    public static readonly PayCurrencyEnum Ara = new(Values.Ara);

    public static readonly PayCurrencyEnum Ars = new(Values.Ars);

    public static readonly PayCurrencyEnum Arm = new(Values.Arm);

    public static readonly PayCurrencyEnum Arp = new(Values.Arp);

    public static readonly PayCurrencyEnum Arl = new(Values.Arl);

    public static readonly PayCurrencyEnum Amd = new(Values.Amd);

    public static readonly PayCurrencyEnum Awg = new(Values.Awg);

    public static readonly PayCurrencyEnum Aud = new(Values.Aud);

    public static readonly PayCurrencyEnum Ats = new(Values.Ats);

    public static readonly PayCurrencyEnum Azn = new(Values.Azn);

    public static readonly PayCurrencyEnum Azm = new(Values.Azm);

    public static readonly PayCurrencyEnum Bsd = new(Values.Bsd);

    public static readonly PayCurrencyEnum Bhd = new(Values.Bhd);

    public static readonly PayCurrencyEnum Bdt = new(Values.Bdt);

    public static readonly PayCurrencyEnum Bbd = new(Values.Bbd);

    public static readonly PayCurrencyEnum Byn = new(Values.Byn);

    public static readonly PayCurrencyEnum Byb = new(Values.Byb);

    public static readonly PayCurrencyEnum Byr = new(Values.Byr);

    public static readonly PayCurrencyEnum Bef = new(Values.Bef);

    public static readonly PayCurrencyEnum Bec = new(Values.Bec);

    public static readonly PayCurrencyEnum Bel = new(Values.Bel);

    public static readonly PayCurrencyEnum Bzd = new(Values.Bzd);

    public static readonly PayCurrencyEnum Bmd = new(Values.Bmd);

    public static readonly PayCurrencyEnum Btn = new(Values.Btn);

    public static readonly PayCurrencyEnum Bob = new(Values.Bob);

    public static readonly PayCurrencyEnum Bol = new(Values.Bol);

    public static readonly PayCurrencyEnum Bov = new(Values.Bov);

    public static readonly PayCurrencyEnum Bop = new(Values.Bop);

    public static readonly PayCurrencyEnum Bam = new(Values.Bam);

    public static readonly PayCurrencyEnum Bad = new(Values.Bad);

    public static readonly PayCurrencyEnum Ban = new(Values.Ban);

    public static readonly PayCurrencyEnum Bwp = new(Values.Bwp);

    public static readonly PayCurrencyEnum Brc = new(Values.Brc);

    public static readonly PayCurrencyEnum Brz = new(Values.Brz);

    public static readonly PayCurrencyEnum Bre = new(Values.Bre);

    public static readonly PayCurrencyEnum Brr = new(Values.Brr);

    public static readonly PayCurrencyEnum Brn = new(Values.Brn);

    public static readonly PayCurrencyEnum Brb = new(Values.Brb);

    public static readonly PayCurrencyEnum Brl = new(Values.Brl);

    public static readonly PayCurrencyEnum Gbp = new(Values.Gbp);

    public static readonly PayCurrencyEnum Bnd = new(Values.Bnd);

    public static readonly PayCurrencyEnum Bgl = new(Values.Bgl);

    public static readonly PayCurrencyEnum Bgn = new(Values.Bgn);

    public static readonly PayCurrencyEnum Bgo = new(Values.Bgo);

    public static readonly PayCurrencyEnum Bgm = new(Values.Bgm);

    public static readonly PayCurrencyEnum Buk = new(Values.Buk);

    public static readonly PayCurrencyEnum Bif = new(Values.Bif);

    public static readonly PayCurrencyEnum Xpf = new(Values.Xpf);

    public static readonly PayCurrencyEnum Khr = new(Values.Khr);

    public static readonly PayCurrencyEnum Cad = new(Values.Cad);

    public static readonly PayCurrencyEnum Cve = new(Values.Cve);

    public static readonly PayCurrencyEnum Kyd = new(Values.Kyd);

    public static readonly PayCurrencyEnum Xaf = new(Values.Xaf);

    public static readonly PayCurrencyEnum Cle = new(Values.Cle);

    public static readonly PayCurrencyEnum Clp = new(Values.Clp);

    public static readonly PayCurrencyEnum Clf = new(Values.Clf);

    public static readonly PayCurrencyEnum Cnx = new(Values.Cnx);

    public static readonly PayCurrencyEnum Cny = new(Values.Cny);

    public static readonly PayCurrencyEnum Cnh = new(Values.Cnh);

    public static readonly PayCurrencyEnum Cop = new(Values.Cop);

    public static readonly PayCurrencyEnum Cou = new(Values.Cou);

    public static readonly PayCurrencyEnum Kmf = new(Values.Kmf);

    public static readonly PayCurrencyEnum Cdf = new(Values.Cdf);

    public static readonly PayCurrencyEnum Crc = new(Values.Crc);

    public static readonly PayCurrencyEnum Hrd = new(Values.Hrd);

    public static readonly PayCurrencyEnum Hrk = new(Values.Hrk);

    public static readonly PayCurrencyEnum Cuc = new(Values.Cuc);

    public static readonly PayCurrencyEnum Cup = new(Values.Cup);

    public static readonly PayCurrencyEnum Cyp = new(Values.Cyp);

    public static readonly PayCurrencyEnum Czk = new(Values.Czk);

    public static readonly PayCurrencyEnum Csk = new(Values.Csk);

    public static readonly PayCurrencyEnum Dkk = new(Values.Dkk);

    public static readonly PayCurrencyEnum Djf = new(Values.Djf);

    public static readonly PayCurrencyEnum Dop = new(Values.Dop);

    public static readonly PayCurrencyEnum Nlg = new(Values.Nlg);

    public static readonly PayCurrencyEnum Xcd = new(Values.Xcd);

    public static readonly PayCurrencyEnum Ddm = new(Values.Ddm);

    public static readonly PayCurrencyEnum Ecs = new(Values.Ecs);

    public static readonly PayCurrencyEnum Ecv = new(Values.Ecv);

    public static readonly PayCurrencyEnum Egp = new(Values.Egp);

    public static readonly PayCurrencyEnum Gqe = new(Values.Gqe);

    public static readonly PayCurrencyEnum Ern = new(Values.Ern);

    public static readonly PayCurrencyEnum Eek = new(Values.Eek);

    public static readonly PayCurrencyEnum Etb = new(Values.Etb);

    public static readonly PayCurrencyEnum Eur = new(Values.Eur);

    public static readonly PayCurrencyEnum Xba = new(Values.Xba);

    public static readonly PayCurrencyEnum Xeu = new(Values.Xeu);

    public static readonly PayCurrencyEnum Xbb = new(Values.Xbb);

    public static readonly PayCurrencyEnum Xbc = new(Values.Xbc);

    public static readonly PayCurrencyEnum Xbd = new(Values.Xbd);

    public static readonly PayCurrencyEnum Fkp = new(Values.Fkp);

    public static readonly PayCurrencyEnum Fjd = new(Values.Fjd);

    public static readonly PayCurrencyEnum Fim = new(Values.Fim);

    public static readonly PayCurrencyEnum Frf = new(Values.Frf);

    public static readonly PayCurrencyEnum Xfo = new(Values.Xfo);

    public static readonly PayCurrencyEnum Xfu = new(Values.Xfu);

    public static readonly PayCurrencyEnum Gmd = new(Values.Gmd);

    public static readonly PayCurrencyEnum Gek = new(Values.Gek);

    public static readonly PayCurrencyEnum Gel = new(Values.Gel);

    public static readonly PayCurrencyEnum Dem = new(Values.Dem);

    public static readonly PayCurrencyEnum Ghs = new(Values.Ghs);

    public static readonly PayCurrencyEnum Ghc = new(Values.Ghc);

    public static readonly PayCurrencyEnum Gip = new(Values.Gip);

    public static readonly PayCurrencyEnum Xau = new(Values.Xau);

    public static readonly PayCurrencyEnum Grd = new(Values.Grd);

    public static readonly PayCurrencyEnum Gtq = new(Values.Gtq);

    public static readonly PayCurrencyEnum Gwp = new(Values.Gwp);

    public static readonly PayCurrencyEnum Gnf = new(Values.Gnf);

    public static readonly PayCurrencyEnum Gns = new(Values.Gns);

    public static readonly PayCurrencyEnum Gyd = new(Values.Gyd);

    public static readonly PayCurrencyEnum Htg = new(Values.Htg);

    public static readonly PayCurrencyEnum Hnl = new(Values.Hnl);

    public static readonly PayCurrencyEnum Hkd = new(Values.Hkd);

    public static readonly PayCurrencyEnum Huf = new(Values.Huf);

    public static readonly PayCurrencyEnum Imp = new(Values.Imp);

    public static readonly PayCurrencyEnum Isk = new(Values.Isk);

    public static readonly PayCurrencyEnum Isj = new(Values.Isj);

    public static readonly PayCurrencyEnum Inr = new(Values.Inr);

    public static readonly PayCurrencyEnum Idr = new(Values.Idr);

    public static readonly PayCurrencyEnum Irr = new(Values.Irr);

    public static readonly PayCurrencyEnum Iqd = new(Values.Iqd);

    public static readonly PayCurrencyEnum Iep = new(Values.Iep);

    public static readonly PayCurrencyEnum Ils = new(Values.Ils);

    public static readonly PayCurrencyEnum Ilp = new(Values.Ilp);

    public static readonly PayCurrencyEnum Ilr = new(Values.Ilr);

    public static readonly PayCurrencyEnum Itl = new(Values.Itl);

    public static readonly PayCurrencyEnum Jmd = new(Values.Jmd);

    public static readonly PayCurrencyEnum Jpy = new(Values.Jpy);

    public static readonly PayCurrencyEnum Jod = new(Values.Jod);

    public static readonly PayCurrencyEnum Kzt = new(Values.Kzt);

    public static readonly PayCurrencyEnum Kes = new(Values.Kes);

    public static readonly PayCurrencyEnum Kwd = new(Values.Kwd);

    public static readonly PayCurrencyEnum Kgs = new(Values.Kgs);

    public static readonly PayCurrencyEnum Lak = new(Values.Lak);

    public static readonly PayCurrencyEnum Lvl = new(Values.Lvl);

    public static readonly PayCurrencyEnum Lvr = new(Values.Lvr);

    public static readonly PayCurrencyEnum Lbp = new(Values.Lbp);

    public static readonly PayCurrencyEnum Lsl = new(Values.Lsl);

    public static readonly PayCurrencyEnum Lrd = new(Values.Lrd);

    public static readonly PayCurrencyEnum Lyd = new(Values.Lyd);

    public static readonly PayCurrencyEnum Ltl = new(Values.Ltl);

    public static readonly PayCurrencyEnum Ltt = new(Values.Ltt);

    public static readonly PayCurrencyEnum Lul = new(Values.Lul);

    public static readonly PayCurrencyEnum Luc = new(Values.Luc);

    public static readonly PayCurrencyEnum Luf = new(Values.Luf);

    public static readonly PayCurrencyEnum Mop = new(Values.Mop);

    public static readonly PayCurrencyEnum Mkd = new(Values.Mkd);

    public static readonly PayCurrencyEnum Mkn = new(Values.Mkn);

    public static readonly PayCurrencyEnum Mga = new(Values.Mga);

    public static readonly PayCurrencyEnum Mgf = new(Values.Mgf);

    public static readonly PayCurrencyEnum Mwk = new(Values.Mwk);

    public static readonly PayCurrencyEnum Myr = new(Values.Myr);

    public static readonly PayCurrencyEnum Mvr = new(Values.Mvr);

    public static readonly PayCurrencyEnum Mvp = new(Values.Mvp);

    public static readonly PayCurrencyEnum Mlf = new(Values.Mlf);

    public static readonly PayCurrencyEnum Mtl = new(Values.Mtl);

    public static readonly PayCurrencyEnum Mtp = new(Values.Mtp);

    public static readonly PayCurrencyEnum Mru = new(Values.Mru);

    public static readonly PayCurrencyEnum Mro = new(Values.Mro);

    public static readonly PayCurrencyEnum Mur = new(Values.Mur);

    public static readonly PayCurrencyEnum Mxv = new(Values.Mxv);

    public static readonly PayCurrencyEnum Mxn = new(Values.Mxn);

    public static readonly PayCurrencyEnum Mxp = new(Values.Mxp);

    public static readonly PayCurrencyEnum Mdc = new(Values.Mdc);

    public static readonly PayCurrencyEnum Mdl = new(Values.Mdl);

    public static readonly PayCurrencyEnum Mcf = new(Values.Mcf);

    public static readonly PayCurrencyEnum Mnt = new(Values.Mnt);

    public static readonly PayCurrencyEnum Mad = new(Values.Mad);

    public static readonly PayCurrencyEnum Maf = new(Values.Maf);

    public static readonly PayCurrencyEnum Mze = new(Values.Mze);

    public static readonly PayCurrencyEnum Mzn = new(Values.Mzn);

    public static readonly PayCurrencyEnum Mzm = new(Values.Mzm);

    public static readonly PayCurrencyEnum Mmk = new(Values.Mmk);

    public static readonly PayCurrencyEnum Nad = new(Values.Nad);

    public static readonly PayCurrencyEnum Npr = new(Values.Npr);

    public static readonly PayCurrencyEnum Ang = new(Values.Ang);

    public static readonly PayCurrencyEnum Twd = new(Values.Twd);

    public static readonly PayCurrencyEnum Nzd = new(Values.Nzd);

    public static readonly PayCurrencyEnum Nio = new(Values.Nio);

    public static readonly PayCurrencyEnum Nic = new(Values.Nic);

    public static readonly PayCurrencyEnum Ngn = new(Values.Ngn);

    public static readonly PayCurrencyEnum Kpw = new(Values.Kpw);

    public static readonly PayCurrencyEnum Nok = new(Values.Nok);

    public static readonly PayCurrencyEnum Omr = new(Values.Omr);

    public static readonly PayCurrencyEnum Pkr = new(Values.Pkr);

    public static readonly PayCurrencyEnum Xpd = new(Values.Xpd);

    public static readonly PayCurrencyEnum Pab = new(Values.Pab);

    public static readonly PayCurrencyEnum Pgk = new(Values.Pgk);

    public static readonly PayCurrencyEnum Pyg = new(Values.Pyg);

    public static readonly PayCurrencyEnum Pei = new(Values.Pei);

    public static readonly PayCurrencyEnum Pen = new(Values.Pen);

    public static readonly PayCurrencyEnum Pes = new(Values.Pes);

    public static readonly PayCurrencyEnum Php = new(Values.Php);

    public static readonly PayCurrencyEnum Xpt = new(Values.Xpt);

    public static readonly PayCurrencyEnum Pln = new(Values.Pln);

    public static readonly PayCurrencyEnum Plz = new(Values.Plz);

    public static readonly PayCurrencyEnum Pte = new(Values.Pte);

    public static readonly PayCurrencyEnum Gwe = new(Values.Gwe);

    public static readonly PayCurrencyEnum Qar = new(Values.Qar);

    public static readonly PayCurrencyEnum Xre = new(Values.Xre);

    public static readonly PayCurrencyEnum Rhd = new(Values.Rhd);

    public static readonly PayCurrencyEnum Ron = new(Values.Ron);

    public static readonly PayCurrencyEnum Rol = new(Values.Rol);

    public static readonly PayCurrencyEnum Rub = new(Values.Rub);

    public static readonly PayCurrencyEnum Rur = new(Values.Rur);

    public static readonly PayCurrencyEnum Rwf = new(Values.Rwf);

    public static readonly PayCurrencyEnum Svc = new(Values.Svc);

    public static readonly PayCurrencyEnum Wst = new(Values.Wst);

    public static readonly PayCurrencyEnum Sar = new(Values.Sar);

    public static readonly PayCurrencyEnum Rsd = new(Values.Rsd);

    public static readonly PayCurrencyEnum Csd = new(Values.Csd);

    public static readonly PayCurrencyEnum Scr = new(Values.Scr);

    public static readonly PayCurrencyEnum Sll = new(Values.Sll);

    public static readonly PayCurrencyEnum Xag = new(Values.Xag);

    public static readonly PayCurrencyEnum Sgd = new(Values.Sgd);

    public static readonly PayCurrencyEnum Skk = new(Values.Skk);

    public static readonly PayCurrencyEnum Sit = new(Values.Sit);

    public static readonly PayCurrencyEnum Sbd = new(Values.Sbd);

    public static readonly PayCurrencyEnum Sos = new(Values.Sos);

    public static readonly PayCurrencyEnum Zar = new(Values.Zar);

    public static readonly PayCurrencyEnum Zal = new(Values.Zal);

    public static readonly PayCurrencyEnum Krh = new(Values.Krh);

    public static readonly PayCurrencyEnum Krw = new(Values.Krw);

    public static readonly PayCurrencyEnum Kro = new(Values.Kro);

    public static readonly PayCurrencyEnum Ssp = new(Values.Ssp);

    public static readonly PayCurrencyEnum Sur = new(Values.Sur);

    public static readonly PayCurrencyEnum Esp = new(Values.Esp);

    public static readonly PayCurrencyEnum Esa = new(Values.Esa);

    public static readonly PayCurrencyEnum Esb = new(Values.Esb);

    public static readonly PayCurrencyEnum Xdr = new(Values.Xdr);

    public static readonly PayCurrencyEnum Lkr = new(Values.Lkr);

    public static readonly PayCurrencyEnum Shp = new(Values.Shp);

    public static readonly PayCurrencyEnum Xsu = new(Values.Xsu);

    public static readonly PayCurrencyEnum Sdd = new(Values.Sdd);

    public static readonly PayCurrencyEnum Sdg = new(Values.Sdg);

    public static readonly PayCurrencyEnum Sdp = new(Values.Sdp);

    public static readonly PayCurrencyEnum Srd = new(Values.Srd);

    public static readonly PayCurrencyEnum Srg = new(Values.Srg);

    public static readonly PayCurrencyEnum Szl = new(Values.Szl);

    public static readonly PayCurrencyEnum Sek = new(Values.Sek);

    public static readonly PayCurrencyEnum Chf = new(Values.Chf);

    public static readonly PayCurrencyEnum Syp = new(Values.Syp);

    public static readonly PayCurrencyEnum Stn = new(Values.Stn);

    public static readonly PayCurrencyEnum Std = new(Values.Std);

    public static readonly PayCurrencyEnum Tvd = new(Values.Tvd);

    public static readonly PayCurrencyEnum Tjr = new(Values.Tjr);

    public static readonly PayCurrencyEnum Tjs = new(Values.Tjs);

    public static readonly PayCurrencyEnum Tzs = new(Values.Tzs);

    public static readonly PayCurrencyEnum Xts = new(Values.Xts);

    public static readonly PayCurrencyEnum Thb = new(Values.Thb);

    public static readonly PayCurrencyEnum Xxx = new(Values.Xxx);

    public static readonly PayCurrencyEnum Tpe = new(Values.Tpe);

    public static readonly PayCurrencyEnum Top = new(Values.Top);

    public static readonly PayCurrencyEnum Ttd = new(Values.Ttd);

    public static readonly PayCurrencyEnum Tnd = new(Values.Tnd);

    public static readonly PayCurrencyEnum Try = new(Values.Try);

    public static readonly PayCurrencyEnum Trl = new(Values.Trl);

    public static readonly PayCurrencyEnum Tmt = new(Values.Tmt);

    public static readonly PayCurrencyEnum Tmm = new(Values.Tmm);

    public static readonly PayCurrencyEnum Usd = new(Values.Usd);

    public static readonly PayCurrencyEnum Usn = new(Values.Usn);

    public static readonly PayCurrencyEnum Uss = new(Values.Uss);

    public static readonly PayCurrencyEnum Ugx = new(Values.Ugx);

    public static readonly PayCurrencyEnum Ugs = new(Values.Ugs);

    public static readonly PayCurrencyEnum Uah = new(Values.Uah);

    public static readonly PayCurrencyEnum Uak = new(Values.Uak);

    public static readonly PayCurrencyEnum Aed = new(Values.Aed);

    public static readonly PayCurrencyEnum Uyw = new(Values.Uyw);

    public static readonly PayCurrencyEnum Uyu = new(Values.Uyu);

    public static readonly PayCurrencyEnum Uyp = new(Values.Uyp);

    public static readonly PayCurrencyEnum Uyi = new(Values.Uyi);

    public static readonly PayCurrencyEnum Uzs = new(Values.Uzs);

    public static readonly PayCurrencyEnum Vuv = new(Values.Vuv);

    public static readonly PayCurrencyEnum Ves = new(Values.Ves);

    public static readonly PayCurrencyEnum Veb = new(Values.Veb);

    public static readonly PayCurrencyEnum Vef = new(Values.Vef);

    public static readonly PayCurrencyEnum Vnd = new(Values.Vnd);

    public static readonly PayCurrencyEnum Vnn = new(Values.Vnn);

    public static readonly PayCurrencyEnum Che = new(Values.Che);

    public static readonly PayCurrencyEnum Chw = new(Values.Chw);

    public static readonly PayCurrencyEnum Xof = new(Values.Xof);

    public static readonly PayCurrencyEnum Ydd = new(Values.Ydd);

    public static readonly PayCurrencyEnum Yer = new(Values.Yer);

    public static readonly PayCurrencyEnum Yun = new(Values.Yun);

    public static readonly PayCurrencyEnum Yud = new(Values.Yud);

    public static readonly PayCurrencyEnum Yum = new(Values.Yum);

    public static readonly PayCurrencyEnum Yur = new(Values.Yur);

    public static readonly PayCurrencyEnum Zwn = new(Values.Zwn);

    public static readonly PayCurrencyEnum Zrn = new(Values.Zrn);

    public static readonly PayCurrencyEnum Zrz = new(Values.Zrz);

    public static readonly PayCurrencyEnum Zmw = new(Values.Zmw);

    public static readonly PayCurrencyEnum Zmk = new(Values.Zmk);

    public static readonly PayCurrencyEnum Zwd = new(Values.Zwd);

    public static readonly PayCurrencyEnum Zwr = new(Values.Zwr);

    public static readonly PayCurrencyEnum Zwl = new(Values.Zwl);

    public PayCurrencyEnum(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static PayCurrencyEnum FromCustom(string value)
    {
        return new PayCurrencyEnum(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(PayCurrencyEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PayCurrencyEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PayCurrencyEnum value) => value.Value;

    public static explicit operator PayCurrencyEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Xua = "XUA";

        public const string Afn = "AFN";

        public const string Afa = "AFA";

        public const string All = "ALL";

        public const string Alk = "ALK";

        public const string Dzd = "DZD";

        public const string Adp = "ADP";

        public const string Aoa = "AOA";

        public const string Aok = "AOK";

        public const string Aon = "AON";

        public const string Aor = "AOR";

        public const string Ara = "ARA";

        public const string Ars = "ARS";

        public const string Arm = "ARM";

        public const string Arp = "ARP";

        public const string Arl = "ARL";

        public const string Amd = "AMD";

        public const string Awg = "AWG";

        public const string Aud = "AUD";

        public const string Ats = "ATS";

        public const string Azn = "AZN";

        public const string Azm = "AZM";

        public const string Bsd = "BSD";

        public const string Bhd = "BHD";

        public const string Bdt = "BDT";

        public const string Bbd = "BBD";

        public const string Byn = "BYN";

        public const string Byb = "BYB";

        public const string Byr = "BYR";

        public const string Bef = "BEF";

        public const string Bec = "BEC";

        public const string Bel = "BEL";

        public const string Bzd = "BZD";

        public const string Bmd = "BMD";

        public const string Btn = "BTN";

        public const string Bob = "BOB";

        public const string Bol = "BOL";

        public const string Bov = "BOV";

        public const string Bop = "BOP";

        public const string Bam = "BAM";

        public const string Bad = "BAD";

        public const string Ban = "BAN";

        public const string Bwp = "BWP";

        public const string Brc = "BRC";

        public const string Brz = "BRZ";

        public const string Bre = "BRE";

        public const string Brr = "BRR";

        public const string Brn = "BRN";

        public const string Brb = "BRB";

        public const string Brl = "BRL";

        public const string Gbp = "GBP";

        public const string Bnd = "BND";

        public const string Bgl = "BGL";

        public const string Bgn = "BGN";

        public const string Bgo = "BGO";

        public const string Bgm = "BGM";

        public const string Buk = "BUK";

        public const string Bif = "BIF";

        public const string Xpf = "XPF";

        public const string Khr = "KHR";

        public const string Cad = "CAD";

        public const string Cve = "CVE";

        public const string Kyd = "KYD";

        public const string Xaf = "XAF";

        public const string Cle = "CLE";

        public const string Clp = "CLP";

        public const string Clf = "CLF";

        public const string Cnx = "CNX";

        public const string Cny = "CNY";

        public const string Cnh = "CNH";

        public const string Cop = "COP";

        public const string Cou = "COU";

        public const string Kmf = "KMF";

        public const string Cdf = "CDF";

        public const string Crc = "CRC";

        public const string Hrd = "HRD";

        public const string Hrk = "HRK";

        public const string Cuc = "CUC";

        public const string Cup = "CUP";

        public const string Cyp = "CYP";

        public const string Czk = "CZK";

        public const string Csk = "CSK";

        public const string Dkk = "DKK";

        public const string Djf = "DJF";

        public const string Dop = "DOP";

        public const string Nlg = "NLG";

        public const string Xcd = "XCD";

        public const string Ddm = "DDM";

        public const string Ecs = "ECS";

        public const string Ecv = "ECV";

        public const string Egp = "EGP";

        public const string Gqe = "GQE";

        public const string Ern = "ERN";

        public const string Eek = "EEK";

        public const string Etb = "ETB";

        public const string Eur = "EUR";

        public const string Xba = "XBA";

        public const string Xeu = "XEU";

        public const string Xbb = "XBB";

        public const string Xbc = "XBC";

        public const string Xbd = "XBD";

        public const string Fkp = "FKP";

        public const string Fjd = "FJD";

        public const string Fim = "FIM";

        public const string Frf = "FRF";

        public const string Xfo = "XFO";

        public const string Xfu = "XFU";

        public const string Gmd = "GMD";

        public const string Gek = "GEK";

        public const string Gel = "GEL";

        public const string Dem = "DEM";

        public const string Ghs = "GHS";

        public const string Ghc = "GHC";

        public const string Gip = "GIP";

        public const string Xau = "XAU";

        public const string Grd = "GRD";

        public const string Gtq = "GTQ";

        public const string Gwp = "GWP";

        public const string Gnf = "GNF";

        public const string Gns = "GNS";

        public const string Gyd = "GYD";

        public const string Htg = "HTG";

        public const string Hnl = "HNL";

        public const string Hkd = "HKD";

        public const string Huf = "HUF";

        public const string Imp = "IMP";

        public const string Isk = "ISK";

        public const string Isj = "ISJ";

        public const string Inr = "INR";

        public const string Idr = "IDR";

        public const string Irr = "IRR";

        public const string Iqd = "IQD";

        public const string Iep = "IEP";

        public const string Ils = "ILS";

        public const string Ilp = "ILP";

        public const string Ilr = "ILR";

        public const string Itl = "ITL";

        public const string Jmd = "JMD";

        public const string Jpy = "JPY";

        public const string Jod = "JOD";

        public const string Kzt = "KZT";

        public const string Kes = "KES";

        public const string Kwd = "KWD";

        public const string Kgs = "KGS";

        public const string Lak = "LAK";

        public const string Lvl = "LVL";

        public const string Lvr = "LVR";

        public const string Lbp = "LBP";

        public const string Lsl = "LSL";

        public const string Lrd = "LRD";

        public const string Lyd = "LYD";

        public const string Ltl = "LTL";

        public const string Ltt = "LTT";

        public const string Lul = "LUL";

        public const string Luc = "LUC";

        public const string Luf = "LUF";

        public const string Mop = "MOP";

        public const string Mkd = "MKD";

        public const string Mkn = "MKN";

        public const string Mga = "MGA";

        public const string Mgf = "MGF";

        public const string Mwk = "MWK";

        public const string Myr = "MYR";

        public const string Mvr = "MVR";

        public const string Mvp = "MVP";

        public const string Mlf = "MLF";

        public const string Mtl = "MTL";

        public const string Mtp = "MTP";

        public const string Mru = "MRU";

        public const string Mro = "MRO";

        public const string Mur = "MUR";

        public const string Mxv = "MXV";

        public const string Mxn = "MXN";

        public const string Mxp = "MXP";

        public const string Mdc = "MDC";

        public const string Mdl = "MDL";

        public const string Mcf = "MCF";

        public const string Mnt = "MNT";

        public const string Mad = "MAD";

        public const string Maf = "MAF";

        public const string Mze = "MZE";

        public const string Mzn = "MZN";

        public const string Mzm = "MZM";

        public const string Mmk = "MMK";

        public const string Nad = "NAD";

        public const string Npr = "NPR";

        public const string Ang = "ANG";

        public const string Twd = "TWD";

        public const string Nzd = "NZD";

        public const string Nio = "NIO";

        public const string Nic = "NIC";

        public const string Ngn = "NGN";

        public const string Kpw = "KPW";

        public const string Nok = "NOK";

        public const string Omr = "OMR";

        public const string Pkr = "PKR";

        public const string Xpd = "XPD";

        public const string Pab = "PAB";

        public const string Pgk = "PGK";

        public const string Pyg = "PYG";

        public const string Pei = "PEI";

        public const string Pen = "PEN";

        public const string Pes = "PES";

        public const string Php = "PHP";

        public const string Xpt = "XPT";

        public const string Pln = "PLN";

        public const string Plz = "PLZ";

        public const string Pte = "PTE";

        public const string Gwe = "GWE";

        public const string Qar = "QAR";

        public const string Xre = "XRE";

        public const string Rhd = "RHD";

        public const string Ron = "RON";

        public const string Rol = "ROL";

        public const string Rub = "RUB";

        public const string Rur = "RUR";

        public const string Rwf = "RWF";

        public const string Svc = "SVC";

        public const string Wst = "WST";

        public const string Sar = "SAR";

        public const string Rsd = "RSD";

        public const string Csd = "CSD";

        public const string Scr = "SCR";

        public const string Sll = "SLL";

        public const string Xag = "XAG";

        public const string Sgd = "SGD";

        public const string Skk = "SKK";

        public const string Sit = "SIT";

        public const string Sbd = "SBD";

        public const string Sos = "SOS";

        public const string Zar = "ZAR";

        public const string Zal = "ZAL";

        public const string Krh = "KRH";

        public const string Krw = "KRW";

        public const string Kro = "KRO";

        public const string Ssp = "SSP";

        public const string Sur = "SUR";

        public const string Esp = "ESP";

        public const string Esa = "ESA";

        public const string Esb = "ESB";

        public const string Xdr = "XDR";

        public const string Lkr = "LKR";

        public const string Shp = "SHP";

        public const string Xsu = "XSU";

        public const string Sdd = "SDD";

        public const string Sdg = "SDG";

        public const string Sdp = "SDP";

        public const string Srd = "SRD";

        public const string Srg = "SRG";

        public const string Szl = "SZL";

        public const string Sek = "SEK";

        public const string Chf = "CHF";

        public const string Syp = "SYP";

        public const string Stn = "STN";

        public const string Std = "STD";

        public const string Tvd = "TVD";

        public const string Tjr = "TJR";

        public const string Tjs = "TJS";

        public const string Tzs = "TZS";

        public const string Xts = "XTS";

        public const string Thb = "THB";

        public const string Xxx = "XXX";

        public const string Tpe = "TPE";

        public const string Top = "TOP";

        public const string Ttd = "TTD";

        public const string Tnd = "TND";

        public const string Try = "TRY";

        public const string Trl = "TRL";

        public const string Tmt = "TMT";

        public const string Tmm = "TMM";

        public const string Usd = "USD";

        public const string Usn = "USN";

        public const string Uss = "USS";

        public const string Ugx = "UGX";

        public const string Ugs = "UGS";

        public const string Uah = "UAH";

        public const string Uak = "UAK";

        public const string Aed = "AED";

        public const string Uyw = "UYW";

        public const string Uyu = "UYU";

        public const string Uyp = "UYP";

        public const string Uyi = "UYI";

        public const string Uzs = "UZS";

        public const string Vuv = "VUV";

        public const string Ves = "VES";

        public const string Veb = "VEB";

        public const string Vef = "VEF";

        public const string Vnd = "VND";

        public const string Vnn = "VNN";

        public const string Che = "CHE";

        public const string Chw = "CHW";

        public const string Xof = "XOF";

        public const string Ydd = "YDD";

        public const string Yer = "YER";

        public const string Yun = "YUN";

        public const string Yud = "YUD";

        public const string Yum = "YUM";

        public const string Yur = "YUR";

        public const string Zwn = "ZWN";

        public const string Zrn = "ZRN";

        public const string Zrz = "ZRZ";

        public const string Zmw = "ZMW";

        public const string Zmk = "ZMK";

        public const string Zwd = "ZWD";

        public const string Zwr = "ZWR";

        public const string Zwl = "ZWL";
    }
}
