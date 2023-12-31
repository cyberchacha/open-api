using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>옵션매도주문증거금</summary>
public class MultiOpw20015
{
    /// <summary>콜조정이론가</summary>
    [DataMember, JsonProperty("콜조정이론가")]
    public string? 콜조정이론가
    {
        get; set;
    }
    /// <summary>콜최대이론가</summary>
    [DataMember, JsonProperty("콜최대이론가")]
    public string? 콜최대이론가
    {
        get; set;
    }
    /// <summary>콜전일종가</summary>
    [DataMember, JsonProperty("콜전일종가")]
    public string? 콜전일종가
    {
        get; set;
    }
    /// <summary>콜주문증거금</summary>
    [DataMember, JsonProperty("콜주문증거금")]
    public string? 콜주문증거금
    {
        get; set;
    }
    /// <summary>행사가격</summary>
    [DataMember, JsonProperty("행사가격")]
    public string? 행사가격
    {
        get; set;
    }
    /// <summary>풋주문증거금</summary>
    [DataMember, JsonProperty("풋주문증거금")]
    public string? 풋주문증거금
    {
        get; set;
    }
    /// <summary>풋전일종가</summary>
    [DataMember, JsonProperty("풋전일종가")]
    public string? 풋전일종가
    {
        get; set;
    }
    /// <summary>풋최대이론가</summary>
    [DataMember, JsonProperty("풋최대이론가")]
    public string? 풋최대이론가
    {
        get; set;
    }
    /// <summary>풋조정이론가</summary>
    [DataMember, JsonProperty("풋조정이론가")]
    public string? 풋조정이론가
    {
        get; set;
    }
}