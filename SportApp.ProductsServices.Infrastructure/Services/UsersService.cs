namespace SportApp.ProductsServices.Infrastructure.Services ;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;
using System.Text;
using Application.Recommendation.Interfaces;
using Constants;
using Domain.Recommendations.DTO;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

    public class UsersService(
        [NotNull] IOptions<UserService> options) : IUsersService
    {
        private readonly HttpClient _httpClient = new();
        private readonly string _userUrl = "https://usersapi20240517141918.azurewebsites.net";

        public async Task<ICollection<UserProfileDto>> GetUsersAsync(GetUsersFiltersQuery query)
        {
            var url = $"{_userUrl}/api/V1/UserSportProfile/filters-user";
            var token = await LoginAsync();
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var content = new StringContent(JsonConvert.SerializeObject(query), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(url, content);
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            var responseModel = JsonConvert.DeserializeObject<ICollection<UserProfileDto>>(responseContent);

            return responseModel;
        }

        private async Task<string> LoginAsync()
        {
            var url = $"{_userUrl}/api/V1/Account/Login";
            var loginData = new
            {
                email = "camiloandresgtr@gmail.com",
                password = "Hope2028*"
            };
            var content = new StringContent(JsonConvert.SerializeObject(loginData), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(url, content);
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            var loginResponse = JsonConvert.DeserializeObject<LoginResponse>(responseContent);

            return loginResponse!.Token;
        }
    }

    public class LoginResponse
    {
        public string Token { get; set; }
    }
