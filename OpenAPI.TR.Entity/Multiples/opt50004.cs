using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>콜옵션행사가</summary>
public class MultiOpt50004
{
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? 종목코드
    {
        get; set;
    }
    /// <summary>ATM구분</summary>
    [DataMember, JsonProperty("ATM구분")]
    public string? ATM구분
    {
        get; set;
    }
    /// <summary>행사가</summary>
    [DataMember, JsonProperty("행사가")]
    public string? 행사가
    {
        get; set;
    }
}