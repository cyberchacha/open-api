using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵종목별기간손익조회</summary>
public class MultiOpw20003
{
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? 종목코드
    {
        get; set;
    }
    /// <summary>매도수구분</summary>
    [DataMember, JsonProperty("매도수구분")]
    public string? 매도수구분
    {
        get; set;
    }
    /// <summary>잔고수량</summary>
    [DataMember, JsonProperty("잔고수량")]
    public string? 잔고수량
    {
        get; set;
    }
    /// <summary>평균가격</summary>
    [DataMember, JsonProperty("평균가격")]
    public string? 평균가격
    {
        get; set;
    }
    /// <summary>전일종가</summary>
    [DataMember, JsonProperty("전일종가")]
    public string? 전일종가
    {
        get; set;
    }
    /// <summary>평가손익</summary>
    [DataMember, JsonProperty("평가손익")]
    public string? 평가손익
    {
        get; set;
    }
    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명")]
    public string? 종목명
    {
        get; set;
    }
}