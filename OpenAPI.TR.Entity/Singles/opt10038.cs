using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>종목별증권사순위_합산</summary>
public class SingleOpt10038
{
    /// <summary>순위1</summary>
    [DataMember, JsonProperty("순위1")]
    public string? 순위1
    {
        get; set;
    }
    /// <summary>순위2</summary>
    [DataMember, JsonProperty("순위2")]
    public string? 순위2
    {
        get; set;
    }
    /// <summary>순위3</summary>
    [DataMember, JsonProperty("순위3")]
    public string? 순위3
    {
        get; set;
    }
    /// <summary>기간중거래량</summary>
    [DataMember, JsonProperty("기간중거래량")]
    public string? 기간중거래량
    {
        get; set;
    }
}