namespace AmraLibrary
{
    using System.Threading.Tasks;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using AmbraModels;
    using Newtonsoft.Json;
    public class AmbraApiCalls
    {
        private Uri _baseAddress = new Uri("https://access.ambrahealth.com/api/v3/bundle");
        HttpClient httpClient = new HttpClient();
        private Task<HttpResponseMessage> _callResponse;
        string JsonRequestData = string.Empty;
        public void CreateSession(string userName, string password)
        {
            SessionLoginRequest login = new SessionLoginRequest();
            login.login = userName;
            login.password = password;

            JsonRequestData = "["+ JsonConvert.SerializeObject(login) + "]";
            _callResponse = httpClient.PostAsync(_baseAddress, new StringContent(JsonRequestData, Encoding.UTF8, "application/json"));
            string responseMessage = this._callResponse.Result.Content.ReadAsStringAsync().Result;
            List<object> ResponseList = JsonConvert.DeserializeObject<List<object>>(responseMessage);
            SessionLoginResponse sessionResponse = JsonConvert.DeserializeObject<SessionLoginResponse>(ResponseList[0].ToString()); ;
        }

        public void GetStudyList(string userName, string password)
        {
            StudyListRequestModel _requestModel = new StudyListRequestModel();
            _requestModel.Login.login = userName;
            _requestModel.Login.password = password;
            object[] arr = new object[2];
            arr[0] = _requestModel.Login;
            arr[1] = _requestModel.studyRequest;
            JsonRequestData = JsonConvert.SerializeObject(arr);
            _callResponse = httpClient.PostAsync(_baseAddress, new StringContent(JsonRequestData, Encoding.UTF8, "application/json"));
            string responseMessage = this._callResponse.Result.Content.ReadAsStringAsync().Result;
            List<object> ResponseList = JsonConvert.DeserializeObject<List<object>>(responseMessage);
            SessionLoginResponse sessionResponse = JsonConvert.DeserializeObject<SessionLoginResponse>(ResponseList[0].ToString());
            StudyListModel Studies = JsonConvert.DeserializeObject<StudyListModel>(ResponseList[1].ToString());
        }

        public void GetSingleStudy(string userName, string password)
        {
            StudyRequestModel _requestModel = new StudyRequestModel();
            _requestModel.Login.login = userName;
            _requestModel.Login.password = password;
            _requestModel.studyRequest.uuid = "a5121239-0f9d-4479-a813-37267303e388";
            object[] arr = new object[2];
            arr[0] = _requestModel.Login;
            arr[1] = _requestModel.studyRequest;
            JsonRequestData = JsonConvert.SerializeObject(arr);
            _callResponse = httpClient.PostAsync(_baseAddress, new StringContent(JsonRequestData, Encoding.UTF8, "application/json"));
            string responseMessage = this._callResponse.Result.Content.ReadAsStringAsync().Result;
            List<object> ResponseList = JsonConvert.DeserializeObject<List<object>>(responseMessage);
            SessionLoginResponse sessionResponse = JsonConvert.DeserializeObject<SessionLoginResponse>(ResponseList[0].ToString());
            Study Studies = JsonConvert.DeserializeObject<Study>(ResponseList[1].ToString());
        }


        public void GetWebHookList(string userName, string password, string accountID)
        {
            WebHookListRequestModel _requestModel = new WebHookListRequestModel();
            _requestModel.Login.login = userName;
            _requestModel.Login.password = password;
            _requestModel.webHookRequest.account_id = accountID;
            object[] arr = new object[2];
            arr[0] = _requestModel.Login;
            arr[1] = _requestModel.webHookRequest;
            JsonRequestData = JsonConvert.SerializeObject(arr);
            _callResponse = httpClient.PostAsync(_baseAddress, new StringContent(JsonRequestData, Encoding.UTF8, "application/json"));

            string responseMessage = this._callResponse.Result.Content.ReadAsStringAsync().Result;
            List<object> ResponseList = JsonConvert.DeserializeObject<List<object>>(responseMessage);
            SessionLoginResponse sessionResponse = JsonConvert.DeserializeObject<SessionLoginResponse>(ResponseList[0].ToString());
            WebHookListModel webHooks = JsonConvert.DeserializeObject<WebHookListModel>(ResponseList[1].ToString());
        }
    }
}
