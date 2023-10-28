using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>종목일별프로그램매매추이요청</summary>
public class Opt90013 : TR
{
    /// <summary>종목일별프로그램매매추이</summary>
    [DataMember, JsonProperty("종목일별프로그램매매추이")]
    public MultiOpt90013[]? MultiResponse
    {
        get; set;
    }
    public override string[] Id => new[] { "시간일자구분", "금액수량구분", "종목코드", "날짜" };
    public override string[]? Value
    {
        get; set;
    }
    public override string? RQName
    {
        set
        {

        }
        get => "종목일별프로그램매매추이요청";
    }
    public override string TrCode
    {
        get => nameof(Opt90013);
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
    public override string[] Multiple => new[] { "일자", "현재가", "대비기호", "전일대비", "등락율", "거래량", "프로그램매도금액", "프로그램매수금액", "프로그램순매수금액", "프로그램순매수금액증감", "프로그램매도수량", "프로그램매수수량", "프로그램순매수수량", "프로그램순매수수량증감", "기준가시간", "대차거래상환주수합", "잔고수주합" };
}