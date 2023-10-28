using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace ShareInvest.OpenAPI.Entity;

/// <summary>업종주봉차트</summary>
public class SingleOpt20007
{
    /// <summary>업종코드</summary>
    [DataMember, JsonProperty("업종코드")]
    public string? 업종코드
    {
        get; set;
    }
}