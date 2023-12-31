using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>지수변동성차트요청</summary>
public class OPT50035 : TR
{
    /// <summary>지수변동성차트</summary>
    [DataMember, JsonProperty("지수변동성차트")]
    public MultiOPT50035[]? MultiResponse
    {
        get; set;
    }
    public override string[] Id => new[] { "종목코드", "기준일자", "기간", "차트구분" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "지수변동성차트요청";
    }
    public override string TrCode
    {
        get => nameof(OPT50035);
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
    public override string[] Multiple => new[] { "현재가", "대비기호", "전일대비", "등락율", "시가", "고가", "저가", "누적거래", "거래량" };
}