using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>관심종목프로그램정보</summary>
public class MultiOPTKWPRO
{
    /// <summary>차익매도량</summary>
    [DataMember, JsonProperty("차익매도량")]
    public string? 차익매도량
    {
        get; set;
    }
    /// <summary>차익매도대금</summary>
    [DataMember, JsonProperty("차익매도대금")]
    public string? 차익매도대금
    {
        get; set;
    }
    /// <summary>차익매도비율</summary>
    [DataMember, JsonProperty("차익매도비율")]
    public string? 차익매도비율
    {
        get; set;
    }
    /// <summary>차익매수량</summary>
    [DataMember, JsonProperty("차익매수량")]
    public string? 차익매수량
    {
        get; set;
    }
    /// <summary>차익매수대금</summary>
    [DataMember, JsonProperty("차익매수대금")]
    public string? 차익매수대금
    {
        get; set;
    }
    /// <summary>차익매수비율</summary>
    [DataMember, JsonProperty("차익매수비율")]
    public string? 차익매수비율
    {
        get; set;
    }
    /// <summary>차익순매수금액</summary>
    [DataMember, JsonProperty("차익순매수금액")]
    public string? 차익순매수금액
    {
        get; set;
    }
    /// <summary>비차익매도량</summary>
    [DataMember, JsonProperty("비차익매도량")]
    public string? 비차익매도량
    {
        get; set;
    }
    /// <summary>비차익매도대금</summary>
    [DataMember, JsonProperty("비차익매도대금")]
    public string? 비차익매도대금
    {
        get; set;
    }
    /// <summary>비차익매도비율</summary>
    [DataMember, JsonProperty("비차익매도비율")]
    public string? 비차익매도비율
    {
        get; set;
    }
    /// <summary>비차익매수량</summary>
    [DataMember, JsonProperty("비차익매수량")]
    public string? 비차익매수량
    {
        get; set;
    }
    /// <summary>비차익매수대금</summary>
    [DataMember, JsonProperty("비차익매수대금")]
    public string? 비차익매수대금
    {
        get; set;
    }
    /// <summary>비차익매수비율</summary>
    [DataMember, JsonProperty("비차익매수비율")]
    public string? 비차익매수비율
    {
        get; set;
    }
    /// <summary>비차익순매수금액</summary>
    [DataMember, JsonProperty("비차익순매수금액")]
    public string? 비차익순매수금액
    {
        get; set;
    }
    /// <summary>합계매도량</summary>
    [DataMember, JsonProperty("합계매도량")]
    public string? 합계매도량
    {
        get; set;
    }
    /// <summary>합계매도대금</summary>
    [DataMember, JsonProperty("합계매도대금")]
    public string? 합계매도대금
    {
        get; set;
    }
    /// <summary>합계매수량</summary>
    [DataMember, JsonProperty("합계매수량")]
    public string? 합계매수량
    {
        get; set;
    }
    /// <summary>합계매수대금</summary>
    [DataMember, JsonProperty("합계매수대금")]
    public string? 합계매수대금
    {
        get; set;
    }
    /// <summary>합계순매수</summary>
    [DataMember, JsonProperty("합계순매수")]
    public string? 합계순매수
    {
        get; set;
    }
}