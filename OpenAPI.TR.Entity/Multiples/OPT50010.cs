using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵호가잔량추이</summary>
public class MultiOPT50010
{
    /// <summary>호가시간</summary>
    [DataMember, JsonProperty("호가시간")]
    public string? 호가시간
    {
        get; set;
    }
    /// <summary>매도호가수량</summary>
    [DataMember, JsonProperty("매도호가수량")]
    public string? 매도호가수량
    {
        get; set;
    }
    /// <summary>최우선매도호가</summary>
    [DataMember, JsonProperty("최우선매도호가")]
    public string? 최우선매도호가
    {
        get; set;
    }
    /// <summary>매수호가수량</summary>
    [DataMember, JsonProperty("매수호가수량")]
    public string? 매수호가수량
    {
        get; set;
    }
    /// <summary>최우선매수호가</summary>
    [DataMember, JsonProperty("최우선매수호가")]
    public string? 최우선매수호가
    {
        get; set;
    }
    /// <summary>호가순잔량</summary>
    [DataMember, JsonProperty("호가순잔량")]
    public string? 호가순잔량
    {
        get; set;
    }
    /// <summary>매도호가총잔량</summary>
    [DataMember, JsonProperty("매도호가총잔량")]
    public string? 매도호가총잔량
    {
        get; set;
    }
    /// <summary>매수호가총잔량</summary>
    [DataMember, JsonProperty("매수호가총잔량")]
    public string? 매수호가총잔량
    {
        get; set;
    }
    /// <summary>순매수잔량</summary>
    [DataMember, JsonProperty("순매수잔량")]
    public string? 순매수잔량
    {
        get; set;
    }
}