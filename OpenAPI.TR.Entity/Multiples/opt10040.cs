using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>당일주요거래원</summary>
public class MultiOpt10040
{
    /// <summary>매도이탈시간</summary>
    [DataMember, JsonProperty("매도이탈시간")]
    public string? 매도이탈시간
    {
        get; set;
    }
    /// <summary>매도수량</summary>
    [DataMember, JsonProperty("매도수량")]
    public string? 매도수량
    {
        get; set;
    }
    /// <summary>매도상위이탈원</summary>
    [DataMember, JsonProperty("매도상위이탈원")]
    public string? 매도상위이탈원
    {
        get; set;
    }
    /// <summary>매수이탈시간</summary>
    [DataMember, JsonProperty("매수이탈시간")]
    public string? 매수이탈시간
    {
        get; set;
    }
    /// <summary>매수수량</summary>
    [DataMember, JsonProperty("매수수량")]
    public string? 매수수량
    {
        get; set;
    }
    /// <summary>매수상위이탈원</summary>
    [DataMember, JsonProperty("매수상위이탈원")]
    public string? 매수상위이탈원
    {
        get; set;
    }
    /// <summary>조회일자</summary>
    [DataMember, JsonProperty("조회일자")]
    public string? 조회일자
    {
        get; set;
    }
    /// <summary>조회시간</summary>
    [DataMember, JsonProperty("조회시간")]
    public string? 조회시간
    {
        get; set;
    }
}