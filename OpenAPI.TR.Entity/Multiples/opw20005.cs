using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>선옵주문체결내역상세평균가</summary>
public class MultiOpw20005
{
    /// <summary>주문번호</summary>
    [DataMember, JsonProperty("주문번호")]
    public string? 주문번호
    {
        get; set;
    }
    /// <summary>매매구분</summary>
    [DataMember, JsonProperty("매매구분")]
    public string? 매매구분
    {
        get; set;
    }
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? 종목코드
    {
        get; set;
    }
    /// <summary>주문수량</summary>
    [DataMember, JsonProperty("주문수량")]
    public string? 주문수량
    {
        get; set;
    }
    /// <summary>체결수량</summary>
    [DataMember, JsonProperty("체결수량")]
    public string? 체결수량
    {
        get; set;
    }
    /// <summary>미체결수량</summary>
    [DataMember, JsonProperty("미체결수량")]
    public string? 미체결수량
    {
        get; set;
    }
    /// <summary>접수번호</summary>
    [DataMember, JsonProperty("접수번호")]
    public string? 접수번호
    {
        get; set;
    }
    /// <summary>접수구분</summary>
    [DataMember, JsonProperty("접수구분")]
    public string? 접수구분
    {
        get; set;
    }
    /// <summary>조작자사번</summary>
    [DataMember, JsonProperty("조작자사번")]
    public string? 조작자사번
    {
        get; set;
    }
    /// <summary>원주문번호</summary>
    [DataMember, JsonProperty("원주문번호")]
    public string? 원주문번호
    {
        get; set;
    }
    /// <summary>주문유형</summary>
    [DataMember, JsonProperty("주문유형")]
    public string? 주문유형
    {
        get; set;
    }
    /// <summary>종목명</summary>
    [DataMember, JsonProperty("종목명")]
    public string? 종목명
    {
        get; set;
    }
    /// <summary>주문가격</summary>
    [DataMember, JsonProperty("주문가격")]
    public string? 주문가격
    {
        get; set;
    }
    /// <summary>체결가</summary>
    [DataMember, JsonProperty("체결가")]
    public string? 체결가
    {
        get; set;
    }
    /// <summary>체결번호</summary>
    [DataMember, JsonProperty("체결번호")]
    public string? 체결번호
    {
        get; set;
    }
    /// <summary>약정시간</summary>
    [DataMember, JsonProperty("약정시간")]
    public string? 약정시간
    {
        get; set;
    }
    /// <summary>접수시간</summary>
    [DataMember, JsonProperty("접수시간")]
    public string? 접수시간
    {
        get; set;
    }
    /// <summary>매체</summary>
    [DataMember, JsonProperty("매체")]
    public string? 매체
    {
        get; set;
    }
}