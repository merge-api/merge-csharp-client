using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<CountryEnum>))]
public enum CountryEnum
{
    [EnumMember(Value = "AF")]
    Af,

    [EnumMember(Value = "AX")]
    Ax,

    [EnumMember(Value = "AL")]
    Al,

    [EnumMember(Value = "DZ")]
    Dz,

    [EnumMember(Value = "AS")]
    As,

    [EnumMember(Value = "AD")]
    Ad,

    [EnumMember(Value = "AO")]
    Ao,

    [EnumMember(Value = "AI")]
    Ai,

    [EnumMember(Value = "AQ")]
    Aq,

    [EnumMember(Value = "AG")]
    Ag,

    [EnumMember(Value = "AR")]
    Ar,

    [EnumMember(Value = "AM")]
    Am,

    [EnumMember(Value = "AW")]
    Aw,

    [EnumMember(Value = "AU")]
    Au,

    [EnumMember(Value = "AT")]
    At,

    [EnumMember(Value = "AZ")]
    Az,

    [EnumMember(Value = "BS")]
    Bs,

    [EnumMember(Value = "BH")]
    Bh,

    [EnumMember(Value = "BD")]
    Bd,

    [EnumMember(Value = "BB")]
    Bb,

    [EnumMember(Value = "BY")]
    By,

    [EnumMember(Value = "BE")]
    Be,

    [EnumMember(Value = "BZ")]
    Bz,

    [EnumMember(Value = "BJ")]
    Bj,

    [EnumMember(Value = "BM")]
    Bm,

    [EnumMember(Value = "BT")]
    Bt,

    [EnumMember(Value = "BO")]
    Bo,

    [EnumMember(Value = "BQ")]
    Bq,

    [EnumMember(Value = "BA")]
    Ba,

    [EnumMember(Value = "BW")]
    Bw,

    [EnumMember(Value = "BV")]
    Bv,

    [EnumMember(Value = "BR")]
    Br,

    [EnumMember(Value = "IO")]
    Io,

    [EnumMember(Value = "BN")]
    Bn,

    [EnumMember(Value = "BG")]
    Bg,

    [EnumMember(Value = "BF")]
    Bf,

    [EnumMember(Value = "BI")]
    Bi,

    [EnumMember(Value = "CV")]
    Cv,

    [EnumMember(Value = "KH")]
    Kh,

    [EnumMember(Value = "CM")]
    Cm,

    [EnumMember(Value = "CA")]
    Ca,

    [EnumMember(Value = "KY")]
    Ky,

    [EnumMember(Value = "CF")]
    Cf,

    [EnumMember(Value = "TD")]
    Td,

    [EnumMember(Value = "CL")]
    Cl,

    [EnumMember(Value = "CN")]
    Cn,

    [EnumMember(Value = "CX")]
    Cx,

    [EnumMember(Value = "CC")]
    Cc,

    [EnumMember(Value = "CO")]
    Co,

    [EnumMember(Value = "KM")]
    Km,

    [EnumMember(Value = "CG")]
    Cg,

    [EnumMember(Value = "CD")]
    Cd,

    [EnumMember(Value = "CK")]
    Ck,

    [EnumMember(Value = "CR")]
    Cr,

    [EnumMember(Value = "CI")]
    Ci,

    [EnumMember(Value = "HR")]
    Hr,

    [EnumMember(Value = "CU")]
    Cu,

    [EnumMember(Value = "CW")]
    Cw,

    [EnumMember(Value = "CY")]
    Cy,

    [EnumMember(Value = "CZ")]
    Cz,

    [EnumMember(Value = "DK")]
    Dk,

    [EnumMember(Value = "DJ")]
    Dj,

    [EnumMember(Value = "DM")]
    Dm,

    [EnumMember(Value = "DO")]
    Do,

    [EnumMember(Value = "EC")]
    Ec,

    [EnumMember(Value = "EG")]
    Eg,

    [EnumMember(Value = "SV")]
    Sv,

    [EnumMember(Value = "GQ")]
    Gq,

    [EnumMember(Value = "ER")]
    Er,

    [EnumMember(Value = "EE")]
    Ee,

    [EnumMember(Value = "SZ")]
    Sz,

    [EnumMember(Value = "ET")]
    Et,

    [EnumMember(Value = "FK")]
    Fk,

    [EnumMember(Value = "FO")]
    Fo,

    [EnumMember(Value = "FJ")]
    Fj,

    [EnumMember(Value = "FI")]
    Fi,

    [EnumMember(Value = "FR")]
    Fr,

    [EnumMember(Value = "GF")]
    Gf,

    [EnumMember(Value = "PF")]
    Pf,

    [EnumMember(Value = "TF")]
    Tf,

    [EnumMember(Value = "GA")]
    Ga,

    [EnumMember(Value = "GM")]
    Gm,

    [EnumMember(Value = "GE")]
    Ge,

    [EnumMember(Value = "DE")]
    De,

    [EnumMember(Value = "GH")]
    Gh,

    [EnumMember(Value = "GI")]
    Gi,

    [EnumMember(Value = "GR")]
    Gr,

    [EnumMember(Value = "GL")]
    Gl,

    [EnumMember(Value = "GD")]
    Gd,

    [EnumMember(Value = "GP")]
    Gp,

    [EnumMember(Value = "GU")]
    Gu,

    [EnumMember(Value = "GT")]
    Gt,

    [EnumMember(Value = "GG")]
    Gg,

    [EnumMember(Value = "GN")]
    Gn,

    [EnumMember(Value = "GW")]
    Gw,

    [EnumMember(Value = "GY")]
    Gy,

    [EnumMember(Value = "HT")]
    Ht,

    [EnumMember(Value = "HM")]
    Hm,

    [EnumMember(Value = "VA")]
    Va,

    [EnumMember(Value = "HN")]
    Hn,

    [EnumMember(Value = "HK")]
    Hk,

    [EnumMember(Value = "HU")]
    Hu,

    [EnumMember(Value = "IS")]
    Is,

    [EnumMember(Value = "IN")]
    In,

    [EnumMember(Value = "ID")]
    Id,

    [EnumMember(Value = "IR")]
    Ir,

    [EnumMember(Value = "IQ")]
    Iq,

    [EnumMember(Value = "IE")]
    Ie,

    [EnumMember(Value = "IM")]
    Im,

    [EnumMember(Value = "IL")]
    Il,

    [EnumMember(Value = "IT")]
    It,

    [EnumMember(Value = "JM")]
    Jm,

    [EnumMember(Value = "JP")]
    Jp,

    [EnumMember(Value = "JE")]
    Je,

    [EnumMember(Value = "JO")]
    Jo,

    [EnumMember(Value = "KZ")]
    Kz,

    [EnumMember(Value = "KE")]
    Ke,

    [EnumMember(Value = "KI")]
    Ki,

    [EnumMember(Value = "KW")]
    Kw,

    [EnumMember(Value = "KG")]
    Kg,

    [EnumMember(Value = "LA")]
    La,

    [EnumMember(Value = "LV")]
    Lv,

    [EnumMember(Value = "LB")]
    Lb,

    [EnumMember(Value = "LS")]
    Ls,

    [EnumMember(Value = "LR")]
    Lr,

    [EnumMember(Value = "LY")]
    Ly,

    [EnumMember(Value = "LI")]
    Li,

    [EnumMember(Value = "LT")]
    Lt,

    [EnumMember(Value = "LU")]
    Lu,

    [EnumMember(Value = "MO")]
    Mo,

    [EnumMember(Value = "MG")]
    Mg,

    [EnumMember(Value = "MW")]
    Mw,

    [EnumMember(Value = "MY")]
    My,

    [EnumMember(Value = "MV")]
    Mv,

    [EnumMember(Value = "ML")]
    Ml,

    [EnumMember(Value = "MT")]
    Mt,

    [EnumMember(Value = "MH")]
    Mh,

    [EnumMember(Value = "MQ")]
    Mq,

    [EnumMember(Value = "MR")]
    Mr,

    [EnumMember(Value = "MU")]
    Mu,

    [EnumMember(Value = "YT")]
    Yt,

    [EnumMember(Value = "MX")]
    Mx,

    [EnumMember(Value = "FM")]
    Fm,

    [EnumMember(Value = "MD")]
    Md,

    [EnumMember(Value = "MC")]
    Mc,

    [EnumMember(Value = "MN")]
    Mn,

    [EnumMember(Value = "ME")]
    Me,

    [EnumMember(Value = "MS")]
    Ms,

    [EnumMember(Value = "MA")]
    Ma,

    [EnumMember(Value = "MZ")]
    Mz,

    [EnumMember(Value = "MM")]
    Mm,

    [EnumMember(Value = "NA")]
    Na,

    [EnumMember(Value = "NR")]
    Nr,

    [EnumMember(Value = "NP")]
    Np,

    [EnumMember(Value = "NL")]
    Nl,

    [EnumMember(Value = "NC")]
    Nc,

    [EnumMember(Value = "NZ")]
    Nz,

    [EnumMember(Value = "NI")]
    Ni,

    [EnumMember(Value = "NE")]
    Ne,

    [EnumMember(Value = "NG")]
    Ng,

    [EnumMember(Value = "NU")]
    Nu,

    [EnumMember(Value = "NF")]
    Nf,

    [EnumMember(Value = "KP")]
    Kp,

    [EnumMember(Value = "MK")]
    Mk,

    [EnumMember(Value = "MP")]
    Mp,

    [EnumMember(Value = "NO")]
    No,

    [EnumMember(Value = "OM")]
    Om,

    [EnumMember(Value = "PK")]
    Pk,

    [EnumMember(Value = "PW")]
    Pw,

    [EnumMember(Value = "PS")]
    Ps,

    [EnumMember(Value = "PA")]
    Pa,

    [EnumMember(Value = "PG")]
    Pg,

    [EnumMember(Value = "PY")]
    Py,

    [EnumMember(Value = "PE")]
    Pe,

    [EnumMember(Value = "PH")]
    Ph,

    [EnumMember(Value = "PN")]
    Pn,

    [EnumMember(Value = "PL")]
    Pl,

    [EnumMember(Value = "PT")]
    Pt,

    [EnumMember(Value = "PR")]
    Pr,

    [EnumMember(Value = "QA")]
    Qa,

    [EnumMember(Value = "RE")]
    Re,

    [EnumMember(Value = "RO")]
    Ro,

    [EnumMember(Value = "RU")]
    Ru,

    [EnumMember(Value = "RW")]
    Rw,

    [EnumMember(Value = "BL")]
    Bl,

    [EnumMember(Value = "SH")]
    Sh,

    [EnumMember(Value = "KN")]
    Kn,

    [EnumMember(Value = "LC")]
    Lc,

    [EnumMember(Value = "MF")]
    Mf,

    [EnumMember(Value = "PM")]
    Pm,

    [EnumMember(Value = "VC")]
    Vc,

    [EnumMember(Value = "WS")]
    Ws,

    [EnumMember(Value = "SM")]
    Sm,

    [EnumMember(Value = "ST")]
    St,

    [EnumMember(Value = "SA")]
    Sa,

    [EnumMember(Value = "SN")]
    Sn,

    [EnumMember(Value = "RS")]
    Rs,

    [EnumMember(Value = "SC")]
    Sc,

    [EnumMember(Value = "SL")]
    Sl,

    [EnumMember(Value = "SG")]
    Sg,

    [EnumMember(Value = "SX")]
    Sx,

    [EnumMember(Value = "SK")]
    Sk,

    [EnumMember(Value = "SI")]
    Si,

    [EnumMember(Value = "SB")]
    Sb,

    [EnumMember(Value = "SO")]
    So,

    [EnumMember(Value = "ZA")]
    Za,

    [EnumMember(Value = "GS")]
    Gs,

    [EnumMember(Value = "KR")]
    Kr,

    [EnumMember(Value = "SS")]
    Ss,

    [EnumMember(Value = "ES")]
    Es,

    [EnumMember(Value = "LK")]
    Lk,

    [EnumMember(Value = "SD")]
    Sd,

    [EnumMember(Value = "SR")]
    Sr,

    [EnumMember(Value = "SJ")]
    Sj,

    [EnumMember(Value = "SE")]
    Se,

    [EnumMember(Value = "CH")]
    Ch,

    [EnumMember(Value = "SY")]
    Sy,

    [EnumMember(Value = "TW")]
    Tw,

    [EnumMember(Value = "TJ")]
    Tj,

    [EnumMember(Value = "TZ")]
    Tz,

    [EnumMember(Value = "TH")]
    Th,

    [EnumMember(Value = "TL")]
    Tl,

    [EnumMember(Value = "TG")]
    Tg,

    [EnumMember(Value = "TK")]
    Tk,

    [EnumMember(Value = "TO")]
    To,

    [EnumMember(Value = "TT")]
    Tt,

    [EnumMember(Value = "TN")]
    Tn,

    [EnumMember(Value = "TR")]
    Tr,

    [EnumMember(Value = "TM")]
    Tm,

    [EnumMember(Value = "TC")]
    Tc,

    [EnumMember(Value = "TV")]
    Tv,

    [EnumMember(Value = "UG")]
    Ug,

    [EnumMember(Value = "UA")]
    Ua,

    [EnumMember(Value = "AE")]
    Ae,

    [EnumMember(Value = "GB")]
    Gb,

    [EnumMember(Value = "UM")]
    Um,

    [EnumMember(Value = "US")]
    Us,

    [EnumMember(Value = "UY")]
    Uy,

    [EnumMember(Value = "UZ")]
    Uz,

    [EnumMember(Value = "VU")]
    Vu,

    [EnumMember(Value = "VE")]
    Ve,

    [EnumMember(Value = "VN")]
    Vn,

    [EnumMember(Value = "VG")]
    Vg,

    [EnumMember(Value = "VI")]
    Vi,

    [EnumMember(Value = "WF")]
    Wf,

    [EnumMember(Value = "EH")]
    Eh,

    [EnumMember(Value = "YE")]
    Ye,

    [EnumMember(Value = "ZM")]
    Zm,

    [EnumMember(Value = "ZW")]
    Zw,
}
