using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>호가잔량상위요청</summary>
public class OPT10020 : TR
{
    /// <summary>호가잔량상위</summary>
    [DataMember, JsonProperty("호가잔량상위")]
    public MultiOPT10020[]? MultiResponse
    {
        get; set;
    }
    public override string[] Id => new[] { "시장구분", "정렬구분", "거래량구분", "종목조건", "신용조건" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "호가잔량상위요청";
    }
    public override string TrCode
    {
        get => nameof(OPT10020);
    }
    public override int PrevNext
    {
        get; set;
    }
    public override string ScreenNo
    {
        get => LookupScreenNo;
    }
    public override string[] Single => Array.Empty<string>();
    public override string[] Multiple => new[] { "종목코드", "종목명", "현재가", "전일대비기호", "전일대비", "거래량", "총매도잔량", "총매수잔량", "순매수잔량", "매수비율" };
}