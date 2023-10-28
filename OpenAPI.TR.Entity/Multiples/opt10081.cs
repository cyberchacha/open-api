using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>주식일봉차트조회</summary>
public class MultiOpt10081
{
    /// <summary>종목코드</summary>
    [DataMember, JsonProperty("종목코드")]
    public string? 종목코드
    {
        get; set;
    }
    /// <summary>현재가</summary>
    [DataMember, JsonProperty("현재가")]
    public string? 현재가
    {
        get; set;
    }
    /// <summary>거래량</summary>
    [DataMember, JsonProperty("거래량")]
    public string? 거래량
    {
        get; set;
    }
    /// <summary>거래대금</summary>
    [DataMember, JsonProperty("거래대금")]
    public string? 거래대금
    {
        get; set;
    }
    /// <summary>일자</summary>
    [DataMember, JsonProperty("일자")]
    public string? 일자
    {
        get; set;
    }
    /// <summary>시가</summary>
    [DataMember, JsonProperty("시가")]
    public string? 시가
    {
        get; set;
    }
    /// <summary>고가</summary>
    [DataMember, JsonProperty("고가")]
    public string? 고가
    {
        get; set;
    }
    /// <summary>저가</summary>
    [DataMember, JsonProperty("저가")]
    public string? 저가
    {
        get; set;
    }
    /// <summary>수정주가구분</summary>
    [DataMember, JsonProperty("수정주가구분")]
    public string? 수정주가구분
    {
        get; set;
    }
    /// <summary>수정비율</summary>
    [DataMember, JsonProperty("수정비율")]
    public string? 수정비율
    {
        get; set;
    }
    /// <summary>대업종구분</summary>
    [DataMember, JsonProperty("대업종구분")]
    public string? 대업종구분
    {
        get; set;
    }
    /// <summary>소업종구분</summary>
    [DataMember, JsonProperty("소업종구분")]
    public string? 소업종구분
    {
        get; set;
    }
    /// <summary>종목정보</summary>
    [DataMember, JsonProperty("종목정보")]
    public string? 종목정보
    {
        get; set;
    }
    /// <summary>수정주가이벤트</summary>
    [DataMember, JsonProperty("수정주가이벤트")]
    public string? 수정주가이벤트
    {
        get; set;
    }
    /// <summary>전일종가</summary>
    [DataMember, JsonProperty("전일종가")]
    public string? 전일종가
    {
        get; set;
    }
}