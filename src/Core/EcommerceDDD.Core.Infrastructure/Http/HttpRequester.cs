﻿namespace EcommerceDDD.Core.Infrastructure.Http;

public class HttpRequester(IHttpClientFactory factory) : IHttpRequester
{
    private readonly HttpClient _httpClient = factory.CreateClient();
    private const string Scheme = "Bearer";

    public async Task<T> PostAsync<T>(string url, object body, string? bearerToken = null)
        where T : class
    {
        SetAuthorizationHeader(bearerToken);
        var response = await _httpClient.PostAsync(url, SerializeBody(body));
        return await DeserializeResponse<T>(response);
    }

    public async Task<T> PutAsync<T>(string url, object? body = null, string? bearerToken = null)
        where T : class
    {
        SetAuthorizationHeader(bearerToken);
        HttpResponseMessage responseMessage;

        if (body is null)
            responseMessage = await _httpClient.PutAsync(url, content: null);        
        else        
            responseMessage = await _httpClient.PutAsync(url, SerializeBody(body));

        return await DeserializeResponse<T>(responseMessage);
    }

    public async Task<T> DeleteAsync<T>(string url, object? body = null, string? bearerToken = null)
        where T : class
    {
        SetAuthorizationHeader(bearerToken);

        var httpMessage = new HttpRequestMessage(HttpMethod.Delete, url);

        if (body is null)
            await _httpClient.PutAsync(url, content: null);
        else
            await _httpClient.PutAsync(url, SerializeBody(body));

        var response = await _httpClient.SendAsync(httpMessage);
        return await DeserializeResponse<T>(response);
    }

    public async Task<T> GetAsync<T>(string url, string? bearerToken = null)
        where T : class
    {
        SetAuthorizationHeader(bearerToken);
        var response = await _httpClient.GetAsync(url);
        return await DeserializeResponse<T>(response);
    }

    private void SetAuthorizationHeader(string? bearerToken)
    {
        if (!string.IsNullOrEmpty(bearerToken))
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                Scheme, bearerToken);
        }
    }

    private static StringContent SerializeBody(object body)
    {
        if (body is null)
            throw new ArgumentNullException(nameof(body), "Body is required");

        var json = JsonConvert.SerializeObject(body);
        return new StringContent(json, Encoding.UTF8, "application/json");
    }

    private static async Task<T> DeserializeResponse<T>(HttpResponseMessage response)
    {
        var content = await response.Content.ReadAsStringAsync();
        var deserializedObject = JsonConvert.DeserializeObject<T>(content);
        return deserializedObject!;
    }
}
