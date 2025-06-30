using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<TransactionCurrencyEnum>))]
[Serializable]
public readonly record struct TransactionCurrencyEnum : IStringEnum
{
    public static readonly TransactionCurrencyEnum Xua = new(Values.Xua);

    public static readonly TransactionCurrencyEnum Afn = new(Values.Afn);

    public static readonly TransactionCurrencyEnum Afa = new(Values.Afa);

    public static readonly TransactionCurrencyEnum All = new(Values.All);

    public static readonly TransactionCurrencyEnum Alk = new(Values.Alk);

    public static readonly TransactionCurrencyEnum Dzd = new(Values.Dzd);

    public static readonly TransactionCurrencyEnum Adp = new(Values.Adp);

    public static readonly TransactionCurrencyEnum Aoa = new(Values.Aoa);

    public static readonly TransactionCurrencyEnum Aok = new(Values.Aok);

    public static readonly TransactionCurrencyEnum Aon = new(Values.Aon);

    public static readonly TransactionCurrencyEnum Aor = new(Values.Aor);

    public static readonly TransactionCurrencyEnum Ara = new(Values.Ara);

    public static readonly TransactionCurrencyEnum Ars = new(Values.Ars);

    public static readonly TransactionCurrencyEnum Arm = new(Values.Arm);

    public static readonly TransactionCurrencyEnum Arp = new(Values.Arp);

    public static readonly TransactionCurrencyEnum Arl = new(Values.Arl);

    public static readonly TransactionCurrencyEnum Amd = new(Values.Amd);

    public static readonly TransactionCurrencyEnum Awg = new(Values.Awg);

    public static readonly TransactionCurrencyEnum Aud = new(Values.Aud);

    public static readonly TransactionCurrencyEnum Ats = new(Values.Ats);

    public static readonly TransactionCurrencyEnum Azn = new(Values.Azn);

    public static readonly TransactionCurrencyEnum Azm = new(Values.Azm);

    public static readonly TransactionCurrencyEnum Bsd = new(Values.Bsd);

    public static readonly TransactionCurrencyEnum Bhd = new(Values.Bhd);

    public static readonly TransactionCurrencyEnum Bdt = new(Values.Bdt);

    public static readonly TransactionCurrencyEnum Bbd = new(Values.Bbd);

    public static readonly TransactionCurrencyEnum Byn = new(Values.Byn);

    public static readonly TransactionCurrencyEnum Byb = new(Values.Byb);

    public static readonly TransactionCurrencyEnum Byr = new(Values.Byr);

    public static readonly TransactionCurrencyEnum Bef = new(Values.Bef);

    public static readonly TransactionCurrencyEnum Bec = new(Values.Bec);

    public static readonly TransactionCurrencyEnum Bel = new(Values.Bel);

    public static readonly TransactionCurrencyEnum Bzd = new(Values.Bzd);

    public static readonly TransactionCurrencyEnum Bmd = new(Values.Bmd);

    public static readonly TransactionCurrencyEnum Btn = new(Values.Btn);

    public static readonly TransactionCurrencyEnum Bob = new(Values.Bob);

    public static readonly TransactionCurrencyEnum Bol = new(Values.Bol);

    public static readonly TransactionCurrencyEnum Bov = new(Values.Bov);

    public static readonly TransactionCurrencyEnum Bop = new(Values.Bop);

    public static readonly TransactionCurrencyEnum Bam = new(Values.Bam);

    public static readonly TransactionCurrencyEnum Bad = new(Values.Bad);

    public static readonly TransactionCurrencyEnum Ban = new(Values.Ban);

    public static readonly TransactionCurrencyEnum Bwp = new(Values.Bwp);

    public static readonly TransactionCurrencyEnum Brc = new(Values.Brc);

    public static readonly TransactionCurrencyEnum Brz = new(Values.Brz);

    public static readonly TransactionCurrencyEnum Bre = new(Values.Bre);

    public static readonly TransactionCurrencyEnum Brr = new(Values.Brr);

    public static readonly TransactionCurrencyEnum Brn = new(Values.Brn);

    public static readonly TransactionCurrencyEnum Brb = new(Values.Brb);

    public static readonly TransactionCurrencyEnum Brl = new(Values.Brl);

    public static readonly TransactionCurrencyEnum Gbp = new(Values.Gbp);

    public static readonly TransactionCurrencyEnum Bnd = new(Values.Bnd);

    public static readonly TransactionCurrencyEnum Bgl = new(Values.Bgl);

    public static readonly TransactionCurrencyEnum Bgn = new(Values.Bgn);

    public static readonly TransactionCurrencyEnum Bgo = new(Values.Bgo);

    public static readonly TransactionCurrencyEnum Bgm = new(Values.Bgm);

    public static readonly TransactionCurrencyEnum Buk = new(Values.Buk);

    public static readonly TransactionCurrencyEnum Bif = new(Values.Bif);

    public static readonly TransactionCurrencyEnum Xpf = new(Values.Xpf);

    public static readonly TransactionCurrencyEnum Khr = new(Values.Khr);

    public static readonly TransactionCurrencyEnum Cad = new(Values.Cad);

    public static readonly TransactionCurrencyEnum Cve = new(Values.Cve);

    public static readonly TransactionCurrencyEnum Kyd = new(Values.Kyd);

    public static readonly TransactionCurrencyEnum Xaf = new(Values.Xaf);

    public static readonly TransactionCurrencyEnum Cle = new(Values.Cle);

    public static readonly TransactionCurrencyEnum Clp = new(Values.Clp);

    public static readonly TransactionCurrencyEnum Clf = new(Values.Clf);

    public static readonly TransactionCurrencyEnum Cnx = new(Values.Cnx);

    public static readonly TransactionCurrencyEnum Cny = new(Values.Cny);

    public static readonly TransactionCurrencyEnum Cnh = new(Values.Cnh);

    public static readonly TransactionCurrencyEnum Cop = new(Values.Cop);

    public static readonly TransactionCurrencyEnum Cou = new(Values.Cou);

    public static readonly TransactionCurrencyEnum Kmf = new(Values.Kmf);

    public static readonly TransactionCurrencyEnum Cdf = new(Values.Cdf);

    public static readonly TransactionCurrencyEnum Crc = new(Values.Crc);

    public static readonly TransactionCurrencyEnum Hrd = new(Values.Hrd);

    public static readonly TransactionCurrencyEnum Hrk = new(Values.Hrk);

    public static readonly TransactionCurrencyEnum Cuc = new(Values.Cuc);

    public static readonly TransactionCurrencyEnum Cup = new(Values.Cup);

    public static readonly TransactionCurrencyEnum Cyp = new(Values.Cyp);

    public static readonly TransactionCurrencyEnum Czk = new(Values.Czk);

    public static readonly TransactionCurrencyEnum Csk = new(Values.Csk);

    public static readonly TransactionCurrencyEnum Dkk = new(Values.Dkk);

    public static readonly TransactionCurrencyEnum Djf = new(Values.Djf);

    public static readonly TransactionCurrencyEnum Dop = new(Values.Dop);

    public static readonly TransactionCurrencyEnum Nlg = new(Values.Nlg);

    public static readonly TransactionCurrencyEnum Xcd = new(Values.Xcd);

    public static readonly TransactionCurrencyEnum Ddm = new(Values.Ddm);

    public static readonly TransactionCurrencyEnum Ecs = new(Values.Ecs);

    public static readonly TransactionCurrencyEnum Ecv = new(Values.Ecv);

    public static readonly TransactionCurrencyEnum Egp = new(Values.Egp);

    public static readonly TransactionCurrencyEnum Gqe = new(Values.Gqe);

    public static readonly TransactionCurrencyEnum Ern = new(Values.Ern);

    public static readonly TransactionCurrencyEnum Eek = new(Values.Eek);

    public static readonly TransactionCurrencyEnum Etb = new(Values.Etb);

    public static readonly TransactionCurrencyEnum Eur = new(Values.Eur);

    public static readonly TransactionCurrencyEnum Xba = new(Values.Xba);

    public static readonly TransactionCurrencyEnum Xeu = new(Values.Xeu);

    public static readonly TransactionCurrencyEnum Xbb = new(Values.Xbb);

    public static readonly TransactionCurrencyEnum Xbc = new(Values.Xbc);

    public static readonly TransactionCurrencyEnum Xbd = new(Values.Xbd);

    public static readonly TransactionCurrencyEnum Fkp = new(Values.Fkp);

    public static readonly TransactionCurrencyEnum Fjd = new(Values.Fjd);

    public static readonly TransactionCurrencyEnum Fim = new(Values.Fim);

    public static readonly TransactionCurrencyEnum Frf = new(Values.Frf);

    public static readonly TransactionCurrencyEnum Xfo = new(Values.Xfo);

    public static readonly TransactionCurrencyEnum Xfu = new(Values.Xfu);

    public static readonly TransactionCurrencyEnum Gmd = new(Values.Gmd);

    public static readonly TransactionCurrencyEnum Gek = new(Values.Gek);

    public static readonly TransactionCurrencyEnum Gel = new(Values.Gel);

    public static readonly TransactionCurrencyEnum Dem = new(Values.Dem);

    public static readonly TransactionCurrencyEnum Ghs = new(Values.Ghs);

    public static readonly TransactionCurrencyEnum Ghc = new(Values.Ghc);

    public static readonly TransactionCurrencyEnum Gip = new(Values.Gip);

    public static readonly TransactionCurrencyEnum Xau = new(Values.Xau);

    public static readonly TransactionCurrencyEnum Grd = new(Values.Grd);

    public static readonly TransactionCurrencyEnum Gtq = new(Values.Gtq);

    public static readonly TransactionCurrencyEnum Gwp = new(Values.Gwp);

    public static readonly TransactionCurrencyEnum Gnf = new(Values.Gnf);

    public static readonly TransactionCurrencyEnum Gns = new(Values.Gns);

    public static readonly TransactionCurrencyEnum Gyd = new(Values.Gyd);

    public static readonly TransactionCurrencyEnum Htg = new(Values.Htg);

    public static readonly TransactionCurrencyEnum Hnl = new(Values.Hnl);

    public static readonly TransactionCurrencyEnum Hkd = new(Values.Hkd);

    public static readonly TransactionCurrencyEnum Huf = new(Values.Huf);

    public static readonly TransactionCurrencyEnum Imp = new(Values.Imp);

    public static readonly TransactionCurrencyEnum Isk = new(Values.Isk);

    public static readonly TransactionCurrencyEnum Isj = new(Values.Isj);

    public static readonly TransactionCurrencyEnum Inr = new(Values.Inr);

    public static readonly TransactionCurrencyEnum Idr = new(Values.Idr);

    public static readonly TransactionCurrencyEnum Irr = new(Values.Irr);

    public static readonly TransactionCurrencyEnum Iqd = new(Values.Iqd);

    public static readonly TransactionCurrencyEnum Iep = new(Values.Iep);

    public static readonly TransactionCurrencyEnum Ils = new(Values.Ils);

    public static readonly TransactionCurrencyEnum Ilp = new(Values.Ilp);

    public static readonly TransactionCurrencyEnum Ilr = new(Values.Ilr);

    public static readonly TransactionCurrencyEnum Itl = new(Values.Itl);

    public static readonly TransactionCurrencyEnum Jmd = new(Values.Jmd);

    public static readonly TransactionCurrencyEnum Jpy = new(Values.Jpy);

    public static readonly TransactionCurrencyEnum Jod = new(Values.Jod);

    public static readonly TransactionCurrencyEnum Kzt = new(Values.Kzt);

    public static readonly TransactionCurrencyEnum Kes = new(Values.Kes);

    public static readonly TransactionCurrencyEnum Kwd = new(Values.Kwd);

    public static readonly TransactionCurrencyEnum Kgs = new(Values.Kgs);

    public static readonly TransactionCurrencyEnum Lak = new(Values.Lak);

    public static readonly TransactionCurrencyEnum Lvl = new(Values.Lvl);

    public static readonly TransactionCurrencyEnum Lvr = new(Values.Lvr);

    public static readonly TransactionCurrencyEnum Lbp = new(Values.Lbp);

    public static readonly TransactionCurrencyEnum Lsl = new(Values.Lsl);

    public static readonly TransactionCurrencyEnum Lrd = new(Values.Lrd);

    public static readonly TransactionCurrencyEnum Lyd = new(Values.Lyd);

    public static readonly TransactionCurrencyEnum Ltl = new(Values.Ltl);

    public static readonly TransactionCurrencyEnum Ltt = new(Values.Ltt);

    public static readonly TransactionCurrencyEnum Lul = new(Values.Lul);

    public static readonly TransactionCurrencyEnum Luc = new(Values.Luc);

    public static readonly TransactionCurrencyEnum Luf = new(Values.Luf);

    public static readonly TransactionCurrencyEnum Mop = new(Values.Mop);

    public static readonly TransactionCurrencyEnum Mkd = new(Values.Mkd);

    public static readonly TransactionCurrencyEnum Mkn = new(Values.Mkn);

    public static readonly TransactionCurrencyEnum Mga = new(Values.Mga);

    public static readonly TransactionCurrencyEnum Mgf = new(Values.Mgf);

    public static readonly TransactionCurrencyEnum Mwk = new(Values.Mwk);

    public static readonly TransactionCurrencyEnum Myr = new(Values.Myr);

    public static readonly TransactionCurrencyEnum Mvr = new(Values.Mvr);

    public static readonly TransactionCurrencyEnum Mvp = new(Values.Mvp);

    public static readonly TransactionCurrencyEnum Mlf = new(Values.Mlf);

    public static readonly TransactionCurrencyEnum Mtl = new(Values.Mtl);

    public static readonly TransactionCurrencyEnum Mtp = new(Values.Mtp);

    public static readonly TransactionCurrencyEnum Mru = new(Values.Mru);

    public static readonly TransactionCurrencyEnum Mro = new(Values.Mro);

    public static readonly TransactionCurrencyEnum Mur = new(Values.Mur);

    public static readonly TransactionCurrencyEnum Mxv = new(Values.Mxv);

    public static readonly TransactionCurrencyEnum Mxn = new(Values.Mxn);

    public static readonly TransactionCurrencyEnum Mxp = new(Values.Mxp);

    public static readonly TransactionCurrencyEnum Mdc = new(Values.Mdc);

    public static readonly TransactionCurrencyEnum Mdl = new(Values.Mdl);

    public static readonly TransactionCurrencyEnum Mcf = new(Values.Mcf);

    public static readonly TransactionCurrencyEnum Mnt = new(Values.Mnt);

    public static readonly TransactionCurrencyEnum Mad = new(Values.Mad);

    public static readonly TransactionCurrencyEnum Maf = new(Values.Maf);

    public static readonly TransactionCurrencyEnum Mze = new(Values.Mze);

    public static readonly TransactionCurrencyEnum Mzn = new(Values.Mzn);

    public static readonly TransactionCurrencyEnum Mzm = new(Values.Mzm);

    public static readonly TransactionCurrencyEnum Mmk = new(Values.Mmk);

    public static readonly TransactionCurrencyEnum Nad = new(Values.Nad);

    public static readonly TransactionCurrencyEnum Npr = new(Values.Npr);

    public static readonly TransactionCurrencyEnum Ang = new(Values.Ang);

    public static readonly TransactionCurrencyEnum Twd = new(Values.Twd);

    public static readonly TransactionCurrencyEnum Nzd = new(Values.Nzd);

    public static readonly TransactionCurrencyEnum Nio = new(Values.Nio);

    public static readonly TransactionCurrencyEnum Nic = new(Values.Nic);

    public static readonly TransactionCurrencyEnum Ngn = new(Values.Ngn);

    public static readonly TransactionCurrencyEnum Kpw = new(Values.Kpw);

    public static readonly TransactionCurrencyEnum Nok = new(Values.Nok);

    public static readonly TransactionCurrencyEnum Omr = new(Values.Omr);

    public static readonly TransactionCurrencyEnum Pkr = new(Values.Pkr);

    public static readonly TransactionCurrencyEnum Xpd = new(Values.Xpd);

    public static readonly TransactionCurrencyEnum Pab = new(Values.Pab);

    public static readonly TransactionCurrencyEnum Pgk = new(Values.Pgk);

    public static readonly TransactionCurrencyEnum Pyg = new(Values.Pyg);

    public static readonly TransactionCurrencyEnum Pei = new(Values.Pei);

    public static readonly TransactionCurrencyEnum Pen = new(Values.Pen);

    public static readonly TransactionCurrencyEnum Pes = new(Values.Pes);

    public static readonly TransactionCurrencyEnum Php = new(Values.Php);

    public static readonly TransactionCurrencyEnum Xpt = new(Values.Xpt);

    public static readonly TransactionCurrencyEnum Pln = new(Values.Pln);

    public static readonly TransactionCurrencyEnum Plz = new(Values.Plz);

    public static readonly TransactionCurrencyEnum Pte = new(Values.Pte);

    public static readonly TransactionCurrencyEnum Gwe = new(Values.Gwe);

    public static readonly TransactionCurrencyEnum Qar = new(Values.Qar);

    public static readonly TransactionCurrencyEnum Xre = new(Values.Xre);

    public static readonly TransactionCurrencyEnum Rhd = new(Values.Rhd);

    public static readonly TransactionCurrencyEnum Ron = new(Values.Ron);

    public static readonly TransactionCurrencyEnum Rol = new(Values.Rol);

    public static readonly TransactionCurrencyEnum Rub = new(Values.Rub);

    public static readonly TransactionCurrencyEnum Rur = new(Values.Rur);

    public static readonly TransactionCurrencyEnum Rwf = new(Values.Rwf);

    public static readonly TransactionCurrencyEnum Svc = new(Values.Svc);

    public static readonly TransactionCurrencyEnum Wst = new(Values.Wst);

    public static readonly TransactionCurrencyEnum Sar = new(Values.Sar);

    public static readonly TransactionCurrencyEnum Rsd = new(Values.Rsd);

    public static readonly TransactionCurrencyEnum Csd = new(Values.Csd);

    public static readonly TransactionCurrencyEnum Scr = new(Values.Scr);

    public static readonly TransactionCurrencyEnum Sll = new(Values.Sll);

    public static readonly TransactionCurrencyEnum Xag = new(Values.Xag);

    public static readonly TransactionCurrencyEnum Sgd = new(Values.Sgd);

    public static readonly TransactionCurrencyEnum Skk = new(Values.Skk);

    public static readonly TransactionCurrencyEnum Sit = new(Values.Sit);

    public static readonly TransactionCurrencyEnum Sbd = new(Values.Sbd);

    public static readonly TransactionCurrencyEnum Sos = new(Values.Sos);

    public static readonly TransactionCurrencyEnum Zar = new(Values.Zar);

    public static readonly TransactionCurrencyEnum Zal = new(Values.Zal);

    public static readonly TransactionCurrencyEnum Krh = new(Values.Krh);

    public static readonly TransactionCurrencyEnum Krw = new(Values.Krw);

    public static readonly TransactionCurrencyEnum Kro = new(Values.Kro);

    public static readonly TransactionCurrencyEnum Ssp = new(Values.Ssp);

    public static readonly TransactionCurrencyEnum Sur = new(Values.Sur);

    public static readonly TransactionCurrencyEnum Esp = new(Values.Esp);

    public static readonly TransactionCurrencyEnum Esa = new(Values.Esa);

    public static readonly TransactionCurrencyEnum Esb = new(Values.Esb);

    public static readonly TransactionCurrencyEnum Xdr = new(Values.Xdr);

    public static readonly TransactionCurrencyEnum Lkr = new(Values.Lkr);

    public static readonly TransactionCurrencyEnum Shp = new(Values.Shp);

    public static readonly TransactionCurrencyEnum Xsu = new(Values.Xsu);

    public static readonly TransactionCurrencyEnum Sdd = new(Values.Sdd);

    public static readonly TransactionCurrencyEnum Sdg = new(Values.Sdg);

    public static readonly TransactionCurrencyEnum Sdp = new(Values.Sdp);

    public static readonly TransactionCurrencyEnum Srd = new(Values.Srd);

    public static readonly TransactionCurrencyEnum Srg = new(Values.Srg);

    public static readonly TransactionCurrencyEnum Szl = new(Values.Szl);

    public static readonly TransactionCurrencyEnum Sek = new(Values.Sek);

    public static readonly TransactionCurrencyEnum Chf = new(Values.Chf);

    public static readonly TransactionCurrencyEnum Syp = new(Values.Syp);

    public static readonly TransactionCurrencyEnum Stn = new(Values.Stn);

    public static readonly TransactionCurrencyEnum Std = new(Values.Std);

    public static readonly TransactionCurrencyEnum Tvd = new(Values.Tvd);

    public static readonly TransactionCurrencyEnum Tjr = new(Values.Tjr);

    public static readonly TransactionCurrencyEnum Tjs = new(Values.Tjs);

    public static readonly TransactionCurrencyEnum Tzs = new(Values.Tzs);

    public static readonly TransactionCurrencyEnum Xts = new(Values.Xts);

    public static readonly TransactionCurrencyEnum Thb = new(Values.Thb);

    public static readonly TransactionCurrencyEnum Xxx = new(Values.Xxx);

    public static readonly TransactionCurrencyEnum Tpe = new(Values.Tpe);

    public static readonly TransactionCurrencyEnum Top = new(Values.Top);

    public static readonly TransactionCurrencyEnum Ttd = new(Values.Ttd);

    public static readonly TransactionCurrencyEnum Tnd = new(Values.Tnd);

    public static readonly TransactionCurrencyEnum Try = new(Values.Try);

    public static readonly TransactionCurrencyEnum Trl = new(Values.Trl);

    public static readonly TransactionCurrencyEnum Tmt = new(Values.Tmt);

    public static readonly TransactionCurrencyEnum Tmm = new(Values.Tmm);

    public static readonly TransactionCurrencyEnum Usd = new(Values.Usd);

    public static readonly TransactionCurrencyEnum Usn = new(Values.Usn);

    public static readonly TransactionCurrencyEnum Uss = new(Values.Uss);

    public static readonly TransactionCurrencyEnum Ugx = new(Values.Ugx);

    public static readonly TransactionCurrencyEnum Ugs = new(Values.Ugs);

    public static readonly TransactionCurrencyEnum Uah = new(Values.Uah);

    public static readonly TransactionCurrencyEnum Uak = new(Values.Uak);

    public static readonly TransactionCurrencyEnum Aed = new(Values.Aed);

    public static readonly TransactionCurrencyEnum Uyw = new(Values.Uyw);

    public static readonly TransactionCurrencyEnum Uyu = new(Values.Uyu);

    public static readonly TransactionCurrencyEnum Uyp = new(Values.Uyp);

    public static readonly TransactionCurrencyEnum Uyi = new(Values.Uyi);

    public static readonly TransactionCurrencyEnum Uzs = new(Values.Uzs);

    public static readonly TransactionCurrencyEnum Vuv = new(Values.Vuv);

    public static readonly TransactionCurrencyEnum Ves = new(Values.Ves);

    public static readonly TransactionCurrencyEnum Veb = new(Values.Veb);

    public static readonly TransactionCurrencyEnum Vef = new(Values.Vef);

    public static readonly TransactionCurrencyEnum Vnd = new(Values.Vnd);

    public static readonly TransactionCurrencyEnum Vnn = new(Values.Vnn);

    public static readonly TransactionCurrencyEnum Che = new(Values.Che);

    public static readonly TransactionCurrencyEnum Chw = new(Values.Chw);

    public static readonly TransactionCurrencyEnum Xof = new(Values.Xof);

    public static readonly TransactionCurrencyEnum Ydd = new(Values.Ydd);

    public static readonly TransactionCurrencyEnum Yer = new(Values.Yer);

    public static readonly TransactionCurrencyEnum Yun = new(Values.Yun);

    public static readonly TransactionCurrencyEnum Yud = new(Values.Yud);

    public static readonly TransactionCurrencyEnum Yum = new(Values.Yum);

    public static readonly TransactionCurrencyEnum Yur = new(Values.Yur);

    public static readonly TransactionCurrencyEnum Zwn = new(Values.Zwn);

    public static readonly TransactionCurrencyEnum Zrn = new(Values.Zrn);

    public static readonly TransactionCurrencyEnum Zrz = new(Values.Zrz);

    public static readonly TransactionCurrencyEnum Zmw = new(Values.Zmw);

    public static readonly TransactionCurrencyEnum Zmk = new(Values.Zmk);

    public static readonly TransactionCurrencyEnum Zwd = new(Values.Zwd);

    public static readonly TransactionCurrencyEnum Zwr = new(Values.Zwr);

    public static readonly TransactionCurrencyEnum Zwl = new(Values.Zwl);

    public TransactionCurrencyEnum(string value)
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
    public static TransactionCurrencyEnum FromCustom(string value)
    {
        return new TransactionCurrencyEnum(value);
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

    public static bool operator ==(TransactionCurrencyEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TransactionCurrencyEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TransactionCurrencyEnum value) => value.Value;

    public static explicit operator TransactionCurrencyEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
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
