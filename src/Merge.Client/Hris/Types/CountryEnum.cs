using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<CountryEnum>))]
public readonly record struct CountryEnum : IStringEnum
{
    public static readonly CountryEnum Af = new(Values.Af);

    public static readonly CountryEnum Ax = new(Values.Ax);

    public static readonly CountryEnum Al = new(Values.Al);

    public static readonly CountryEnum Dz = new(Values.Dz);

    public static readonly CountryEnum As = new(Values.As);

    public static readonly CountryEnum Ad = new(Values.Ad);

    public static readonly CountryEnum Ao = new(Values.Ao);

    public static readonly CountryEnum Ai = new(Values.Ai);

    public static readonly CountryEnum Aq = new(Values.Aq);

    public static readonly CountryEnum Ag = new(Values.Ag);

    public static readonly CountryEnum Ar = new(Values.Ar);

    public static readonly CountryEnum Am = new(Values.Am);

    public static readonly CountryEnum Aw = new(Values.Aw);

    public static readonly CountryEnum Au = new(Values.Au);

    public static readonly CountryEnum At = new(Values.At);

    public static readonly CountryEnum Az = new(Values.Az);

    public static readonly CountryEnum Bs = new(Values.Bs);

    public static readonly CountryEnum Bh = new(Values.Bh);

    public static readonly CountryEnum Bd = new(Values.Bd);

    public static readonly CountryEnum Bb = new(Values.Bb);

    public static readonly CountryEnum By = new(Values.By);

    public static readonly CountryEnum Be = new(Values.Be);

    public static readonly CountryEnum Bz = new(Values.Bz);

    public static readonly CountryEnum Bj = new(Values.Bj);

    public static readonly CountryEnum Bm = new(Values.Bm);

    public static readonly CountryEnum Bt = new(Values.Bt);

    public static readonly CountryEnum Bo = new(Values.Bo);

    public static readonly CountryEnum Bq = new(Values.Bq);

    public static readonly CountryEnum Ba = new(Values.Ba);

    public static readonly CountryEnum Bw = new(Values.Bw);

    public static readonly CountryEnum Bv = new(Values.Bv);

    public static readonly CountryEnum Br = new(Values.Br);

    public static readonly CountryEnum Io = new(Values.Io);

    public static readonly CountryEnum Bn = new(Values.Bn);

    public static readonly CountryEnum Bg = new(Values.Bg);

    public static readonly CountryEnum Bf = new(Values.Bf);

    public static readonly CountryEnum Bi = new(Values.Bi);

    public static readonly CountryEnum Cv = new(Values.Cv);

    public static readonly CountryEnum Kh = new(Values.Kh);

    public static readonly CountryEnum Cm = new(Values.Cm);

    public static readonly CountryEnum Ca = new(Values.Ca);

    public static readonly CountryEnum Ky = new(Values.Ky);

    public static readonly CountryEnum Cf = new(Values.Cf);

    public static readonly CountryEnum Td = new(Values.Td);

    public static readonly CountryEnum Cl = new(Values.Cl);

    public static readonly CountryEnum Cn = new(Values.Cn);

    public static readonly CountryEnum Cx = new(Values.Cx);

    public static readonly CountryEnum Cc = new(Values.Cc);

    public static readonly CountryEnum Co = new(Values.Co);

    public static readonly CountryEnum Km = new(Values.Km);

    public static readonly CountryEnum Cg = new(Values.Cg);

    public static readonly CountryEnum Cd = new(Values.Cd);

    public static readonly CountryEnum Ck = new(Values.Ck);

    public static readonly CountryEnum Cr = new(Values.Cr);

    public static readonly CountryEnum Ci = new(Values.Ci);

    public static readonly CountryEnum Hr = new(Values.Hr);

    public static readonly CountryEnum Cu = new(Values.Cu);

    public static readonly CountryEnum Cw = new(Values.Cw);

    public static readonly CountryEnum Cy = new(Values.Cy);

    public static readonly CountryEnum Cz = new(Values.Cz);

    public static readonly CountryEnum Dk = new(Values.Dk);

    public static readonly CountryEnum Dj = new(Values.Dj);

    public static readonly CountryEnum Dm = new(Values.Dm);

    public static readonly CountryEnum Do = new(Values.Do);

    public static readonly CountryEnum Ec = new(Values.Ec);

    public static readonly CountryEnum Eg = new(Values.Eg);

    public static readonly CountryEnum Sv = new(Values.Sv);

    public static readonly CountryEnum Gq = new(Values.Gq);

    public static readonly CountryEnum Er = new(Values.Er);

    public static readonly CountryEnum Ee = new(Values.Ee);

    public static readonly CountryEnum Sz = new(Values.Sz);

    public static readonly CountryEnum Et = new(Values.Et);

    public static readonly CountryEnum Fk = new(Values.Fk);

    public static readonly CountryEnum Fo = new(Values.Fo);

    public static readonly CountryEnum Fj = new(Values.Fj);

    public static readonly CountryEnum Fi = new(Values.Fi);

    public static readonly CountryEnum Fr = new(Values.Fr);

    public static readonly CountryEnum Gf = new(Values.Gf);

    public static readonly CountryEnum Pf = new(Values.Pf);

    public static readonly CountryEnum Tf = new(Values.Tf);

    public static readonly CountryEnum Ga = new(Values.Ga);

    public static readonly CountryEnum Gm = new(Values.Gm);

    public static readonly CountryEnum Ge = new(Values.Ge);

    public static readonly CountryEnum De = new(Values.De);

    public static readonly CountryEnum Gh = new(Values.Gh);

    public static readonly CountryEnum Gi = new(Values.Gi);

    public static readonly CountryEnum Gr = new(Values.Gr);

    public static readonly CountryEnum Gl = new(Values.Gl);

    public static readonly CountryEnum Gd = new(Values.Gd);

    public static readonly CountryEnum Gp = new(Values.Gp);

    public static readonly CountryEnum Gu = new(Values.Gu);

    public static readonly CountryEnum Gt = new(Values.Gt);

    public static readonly CountryEnum Gg = new(Values.Gg);

    public static readonly CountryEnum Gn = new(Values.Gn);

    public static readonly CountryEnum Gw = new(Values.Gw);

    public static readonly CountryEnum Gy = new(Values.Gy);

    public static readonly CountryEnum Ht = new(Values.Ht);

    public static readonly CountryEnum Hm = new(Values.Hm);

    public static readonly CountryEnum Va = new(Values.Va);

    public static readonly CountryEnum Hn = new(Values.Hn);

    public static readonly CountryEnum Hk = new(Values.Hk);

    public static readonly CountryEnum Hu = new(Values.Hu);

    public static readonly CountryEnum Is = new(Values.Is);

    public static readonly CountryEnum In = new(Values.In);

    public static readonly CountryEnum Id = new(Values.Id);

    public static readonly CountryEnum Ir = new(Values.Ir);

    public static readonly CountryEnum Iq = new(Values.Iq);

    public static readonly CountryEnum Ie = new(Values.Ie);

    public static readonly CountryEnum Im = new(Values.Im);

    public static readonly CountryEnum Il = new(Values.Il);

    public static readonly CountryEnum It = new(Values.It);

    public static readonly CountryEnum Jm = new(Values.Jm);

    public static readonly CountryEnum Jp = new(Values.Jp);

    public static readonly CountryEnum Je = new(Values.Je);

    public static readonly CountryEnum Jo = new(Values.Jo);

    public static readonly CountryEnum Kz = new(Values.Kz);

    public static readonly CountryEnum Ke = new(Values.Ke);

    public static readonly CountryEnum Ki = new(Values.Ki);

    public static readonly CountryEnum Kw = new(Values.Kw);

    public static readonly CountryEnum Kg = new(Values.Kg);

    public static readonly CountryEnum La = new(Values.La);

    public static readonly CountryEnum Lv = new(Values.Lv);

    public static readonly CountryEnum Lb = new(Values.Lb);

    public static readonly CountryEnum Ls = new(Values.Ls);

    public static readonly CountryEnum Lr = new(Values.Lr);

    public static readonly CountryEnum Ly = new(Values.Ly);

    public static readonly CountryEnum Li = new(Values.Li);

    public static readonly CountryEnum Lt = new(Values.Lt);

    public static readonly CountryEnum Lu = new(Values.Lu);

    public static readonly CountryEnum Mo = new(Values.Mo);

    public static readonly CountryEnum Mg = new(Values.Mg);

    public static readonly CountryEnum Mw = new(Values.Mw);

    public static readonly CountryEnum My = new(Values.My);

    public static readonly CountryEnum Mv = new(Values.Mv);

    public static readonly CountryEnum Ml = new(Values.Ml);

    public static readonly CountryEnum Mt = new(Values.Mt);

    public static readonly CountryEnum Mh = new(Values.Mh);

    public static readonly CountryEnum Mq = new(Values.Mq);

    public static readonly CountryEnum Mr = new(Values.Mr);

    public static readonly CountryEnum Mu = new(Values.Mu);

    public static readonly CountryEnum Yt = new(Values.Yt);

    public static readonly CountryEnum Mx = new(Values.Mx);

    public static readonly CountryEnum Fm = new(Values.Fm);

    public static readonly CountryEnum Md = new(Values.Md);

    public static readonly CountryEnum Mc = new(Values.Mc);

    public static readonly CountryEnum Mn = new(Values.Mn);

    public static readonly CountryEnum Me = new(Values.Me);

    public static readonly CountryEnum Ms = new(Values.Ms);

    public static readonly CountryEnum Ma = new(Values.Ma);

    public static readonly CountryEnum Mz = new(Values.Mz);

    public static readonly CountryEnum Mm = new(Values.Mm);

    public static readonly CountryEnum Na = new(Values.Na);

    public static readonly CountryEnum Nr = new(Values.Nr);

    public static readonly CountryEnum Np = new(Values.Np);

    public static readonly CountryEnum Nl = new(Values.Nl);

    public static readonly CountryEnum Nc = new(Values.Nc);

    public static readonly CountryEnum Nz = new(Values.Nz);

    public static readonly CountryEnum Ni = new(Values.Ni);

    public static readonly CountryEnum Ne = new(Values.Ne);

    public static readonly CountryEnum Ng = new(Values.Ng);

    public static readonly CountryEnum Nu = new(Values.Nu);

    public static readonly CountryEnum Nf = new(Values.Nf);

    public static readonly CountryEnum Kp = new(Values.Kp);

    public static readonly CountryEnum Mk = new(Values.Mk);

    public static readonly CountryEnum Mp = new(Values.Mp);

    public static readonly CountryEnum No = new(Values.No);

    public static readonly CountryEnum Om = new(Values.Om);

    public static readonly CountryEnum Pk = new(Values.Pk);

    public static readonly CountryEnum Pw = new(Values.Pw);

    public static readonly CountryEnum Ps = new(Values.Ps);

    public static readonly CountryEnum Pa = new(Values.Pa);

    public static readonly CountryEnum Pg = new(Values.Pg);

    public static readonly CountryEnum Py = new(Values.Py);

    public static readonly CountryEnum Pe = new(Values.Pe);

    public static readonly CountryEnum Ph = new(Values.Ph);

    public static readonly CountryEnum Pn = new(Values.Pn);

    public static readonly CountryEnum Pl = new(Values.Pl);

    public static readonly CountryEnum Pt = new(Values.Pt);

    public static readonly CountryEnum Pr = new(Values.Pr);

    public static readonly CountryEnum Qa = new(Values.Qa);

    public static readonly CountryEnum Re = new(Values.Re);

    public static readonly CountryEnum Ro = new(Values.Ro);

    public static readonly CountryEnum Ru = new(Values.Ru);

    public static readonly CountryEnum Rw = new(Values.Rw);

    public static readonly CountryEnum Bl = new(Values.Bl);

    public static readonly CountryEnum Sh = new(Values.Sh);

    public static readonly CountryEnum Kn = new(Values.Kn);

    public static readonly CountryEnum Lc = new(Values.Lc);

    public static readonly CountryEnum Mf = new(Values.Mf);

    public static readonly CountryEnum Pm = new(Values.Pm);

    public static readonly CountryEnum Vc = new(Values.Vc);

    public static readonly CountryEnum Ws = new(Values.Ws);

    public static readonly CountryEnum Sm = new(Values.Sm);

    public static readonly CountryEnum St = new(Values.St);

    public static readonly CountryEnum Sa = new(Values.Sa);

    public static readonly CountryEnum Sn = new(Values.Sn);

    public static readonly CountryEnum Rs = new(Values.Rs);

    public static readonly CountryEnum Sc = new(Values.Sc);

    public static readonly CountryEnum Sl = new(Values.Sl);

    public static readonly CountryEnum Sg = new(Values.Sg);

    public static readonly CountryEnum Sx = new(Values.Sx);

    public static readonly CountryEnum Sk = new(Values.Sk);

    public static readonly CountryEnum Si = new(Values.Si);

    public static readonly CountryEnum Sb = new(Values.Sb);

    public static readonly CountryEnum So = new(Values.So);

    public static readonly CountryEnum Za = new(Values.Za);

    public static readonly CountryEnum Gs = new(Values.Gs);

    public static readonly CountryEnum Kr = new(Values.Kr);

    public static readonly CountryEnum Ss = new(Values.Ss);

    public static readonly CountryEnum Es = new(Values.Es);

    public static readonly CountryEnum Lk = new(Values.Lk);

    public static readonly CountryEnum Sd = new(Values.Sd);

    public static readonly CountryEnum Sr = new(Values.Sr);

    public static readonly CountryEnum Sj = new(Values.Sj);

    public static readonly CountryEnum Se = new(Values.Se);

    public static readonly CountryEnum Ch = new(Values.Ch);

    public static readonly CountryEnum Sy = new(Values.Sy);

    public static readonly CountryEnum Tw = new(Values.Tw);

    public static readonly CountryEnum Tj = new(Values.Tj);

    public static readonly CountryEnum Tz = new(Values.Tz);

    public static readonly CountryEnum Th = new(Values.Th);

    public static readonly CountryEnum Tl = new(Values.Tl);

    public static readonly CountryEnum Tg = new(Values.Tg);

    public static readonly CountryEnum Tk = new(Values.Tk);

    public static readonly CountryEnum To = new(Values.To);

    public static readonly CountryEnum Tt = new(Values.Tt);

    public static readonly CountryEnum Tn = new(Values.Tn);

    public static readonly CountryEnum Tr = new(Values.Tr);

    public static readonly CountryEnum Tm = new(Values.Tm);

    public static readonly CountryEnum Tc = new(Values.Tc);

    public static readonly CountryEnum Tv = new(Values.Tv);

    public static readonly CountryEnum Ug = new(Values.Ug);

    public static readonly CountryEnum Ua = new(Values.Ua);

    public static readonly CountryEnum Ae = new(Values.Ae);

    public static readonly CountryEnum Gb = new(Values.Gb);

    public static readonly CountryEnum Um = new(Values.Um);

    public static readonly CountryEnum Us = new(Values.Us);

    public static readonly CountryEnum Uy = new(Values.Uy);

    public static readonly CountryEnum Uz = new(Values.Uz);

    public static readonly CountryEnum Vu = new(Values.Vu);

    public static readonly CountryEnum Ve = new(Values.Ve);

    public static readonly CountryEnum Vn = new(Values.Vn);

    public static readonly CountryEnum Vg = new(Values.Vg);

    public static readonly CountryEnum Vi = new(Values.Vi);

    public static readonly CountryEnum Wf = new(Values.Wf);

    public static readonly CountryEnum Eh = new(Values.Eh);

    public static readonly CountryEnum Ye = new(Values.Ye);

    public static readonly CountryEnum Zm = new(Values.Zm);

    public static readonly CountryEnum Zw = new(Values.Zw);

    public CountryEnum(string value)
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
    public static CountryEnum FromCustom(string value)
    {
        return new CountryEnum(value);
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

    public static bool operator ==(CountryEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CountryEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CountryEnum value) => value.Value;

    public static explicit operator CountryEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Af = "AF";

        public const string Ax = "AX";

        public const string Al = "AL";

        public const string Dz = "DZ";

        public const string As = "AS";

        public const string Ad = "AD";

        public const string Ao = "AO";

        public const string Ai = "AI";

        public const string Aq = "AQ";

        public const string Ag = "AG";

        public const string Ar = "AR";

        public const string Am = "AM";

        public const string Aw = "AW";

        public const string Au = "AU";

        public const string At = "AT";

        public const string Az = "AZ";

        public const string Bs = "BS";

        public const string Bh = "BH";

        public const string Bd = "BD";

        public const string Bb = "BB";

        public const string By = "BY";

        public const string Be = "BE";

        public const string Bz = "BZ";

        public const string Bj = "BJ";

        public const string Bm = "BM";

        public const string Bt = "BT";

        public const string Bo = "BO";

        public const string Bq = "BQ";

        public const string Ba = "BA";

        public const string Bw = "BW";

        public const string Bv = "BV";

        public const string Br = "BR";

        public const string Io = "IO";

        public const string Bn = "BN";

        public const string Bg = "BG";

        public const string Bf = "BF";

        public const string Bi = "BI";

        public const string Cv = "CV";

        public const string Kh = "KH";

        public const string Cm = "CM";

        public const string Ca = "CA";

        public const string Ky = "KY";

        public const string Cf = "CF";

        public const string Td = "TD";

        public const string Cl = "CL";

        public const string Cn = "CN";

        public const string Cx = "CX";

        public const string Cc = "CC";

        public const string Co = "CO";

        public const string Km = "KM";

        public const string Cg = "CG";

        public const string Cd = "CD";

        public const string Ck = "CK";

        public const string Cr = "CR";

        public const string Ci = "CI";

        public const string Hr = "HR";

        public const string Cu = "CU";

        public const string Cw = "CW";

        public const string Cy = "CY";

        public const string Cz = "CZ";

        public const string Dk = "DK";

        public const string Dj = "DJ";

        public const string Dm = "DM";

        public const string Do = "DO";

        public const string Ec = "EC";

        public const string Eg = "EG";

        public const string Sv = "SV";

        public const string Gq = "GQ";

        public const string Er = "ER";

        public const string Ee = "EE";

        public const string Sz = "SZ";

        public const string Et = "ET";

        public const string Fk = "FK";

        public const string Fo = "FO";

        public const string Fj = "FJ";

        public const string Fi = "FI";

        public const string Fr = "FR";

        public const string Gf = "GF";

        public const string Pf = "PF";

        public const string Tf = "TF";

        public const string Ga = "GA";

        public const string Gm = "GM";

        public const string Ge = "GE";

        public const string De = "DE";

        public const string Gh = "GH";

        public const string Gi = "GI";

        public const string Gr = "GR";

        public const string Gl = "GL";

        public const string Gd = "GD";

        public const string Gp = "GP";

        public const string Gu = "GU";

        public const string Gt = "GT";

        public const string Gg = "GG";

        public const string Gn = "GN";

        public const string Gw = "GW";

        public const string Gy = "GY";

        public const string Ht = "HT";

        public const string Hm = "HM";

        public const string Va = "VA";

        public const string Hn = "HN";

        public const string Hk = "HK";

        public const string Hu = "HU";

        public const string Is = "IS";

        public const string In = "IN";

        public const string Id = "ID";

        public const string Ir = "IR";

        public const string Iq = "IQ";

        public const string Ie = "IE";

        public const string Im = "IM";

        public const string Il = "IL";

        public const string It = "IT";

        public const string Jm = "JM";

        public const string Jp = "JP";

        public const string Je = "JE";

        public const string Jo = "JO";

        public const string Kz = "KZ";

        public const string Ke = "KE";

        public const string Ki = "KI";

        public const string Kw = "KW";

        public const string Kg = "KG";

        public const string La = "LA";

        public const string Lv = "LV";

        public const string Lb = "LB";

        public const string Ls = "LS";

        public const string Lr = "LR";

        public const string Ly = "LY";

        public const string Li = "LI";

        public const string Lt = "LT";

        public const string Lu = "LU";

        public const string Mo = "MO";

        public const string Mg = "MG";

        public const string Mw = "MW";

        public const string My = "MY";

        public const string Mv = "MV";

        public const string Ml = "ML";

        public const string Mt = "MT";

        public const string Mh = "MH";

        public const string Mq = "MQ";

        public const string Mr = "MR";

        public const string Mu = "MU";

        public const string Yt = "YT";

        public const string Mx = "MX";

        public const string Fm = "FM";

        public const string Md = "MD";

        public const string Mc = "MC";

        public const string Mn = "MN";

        public const string Me = "ME";

        public const string Ms = "MS";

        public const string Ma = "MA";

        public const string Mz = "MZ";

        public const string Mm = "MM";

        public const string Na = "NA";

        public const string Nr = "NR";

        public const string Np = "NP";

        public const string Nl = "NL";

        public const string Nc = "NC";

        public const string Nz = "NZ";

        public const string Ni = "NI";

        public const string Ne = "NE";

        public const string Ng = "NG";

        public const string Nu = "NU";

        public const string Nf = "NF";

        public const string Kp = "KP";

        public const string Mk = "MK";

        public const string Mp = "MP";

        public const string No = "NO";

        public const string Om = "OM";

        public const string Pk = "PK";

        public const string Pw = "PW";

        public const string Ps = "PS";

        public const string Pa = "PA";

        public const string Pg = "PG";

        public const string Py = "PY";

        public const string Pe = "PE";

        public const string Ph = "PH";

        public const string Pn = "PN";

        public const string Pl = "PL";

        public const string Pt = "PT";

        public const string Pr = "PR";

        public const string Qa = "QA";

        public const string Re = "RE";

        public const string Ro = "RO";

        public const string Ru = "RU";

        public const string Rw = "RW";

        public const string Bl = "BL";

        public const string Sh = "SH";

        public const string Kn = "KN";

        public const string Lc = "LC";

        public const string Mf = "MF";

        public const string Pm = "PM";

        public const string Vc = "VC";

        public const string Ws = "WS";

        public const string Sm = "SM";

        public const string St = "ST";

        public const string Sa = "SA";

        public const string Sn = "SN";

        public const string Rs = "RS";

        public const string Sc = "SC";

        public const string Sl = "SL";

        public const string Sg = "SG";

        public const string Sx = "SX";

        public const string Sk = "SK";

        public const string Si = "SI";

        public const string Sb = "SB";

        public const string So = "SO";

        public const string Za = "ZA";

        public const string Gs = "GS";

        public const string Kr = "KR";

        public const string Ss = "SS";

        public const string Es = "ES";

        public const string Lk = "LK";

        public const string Sd = "SD";

        public const string Sr = "SR";

        public const string Sj = "SJ";

        public const string Se = "SE";

        public const string Ch = "CH";

        public const string Sy = "SY";

        public const string Tw = "TW";

        public const string Tj = "TJ";

        public const string Tz = "TZ";

        public const string Th = "TH";

        public const string Tl = "TL";

        public const string Tg = "TG";

        public const string Tk = "TK";

        public const string To = "TO";

        public const string Tt = "TT";

        public const string Tn = "TN";

        public const string Tr = "TR";

        public const string Tm = "TM";

        public const string Tc = "TC";

        public const string Tv = "TV";

        public const string Ug = "UG";

        public const string Ua = "UA";

        public const string Ae = "AE";

        public const string Gb = "GB";

        public const string Um = "UM";

        public const string Us = "US";

        public const string Uy = "UY";

        public const string Uz = "UZ";

        public const string Vu = "VU";

        public const string Ve = "VE";

        public const string Vn = "VN";

        public const string Vg = "VG";

        public const string Vi = "VI";

        public const string Wf = "WF";

        public const string Eh = "EH";

        public const string Ye = "YE";

        public const string Zm = "ZM";

        public const string Zw = "ZW";
    }
}
