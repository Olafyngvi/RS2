using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoKuca.Model;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace AutoKuca.WinUI
{
    class APIService
    {
        private string _ruta;
        public static string username;
        public static string pass;
        public APIService(string ruta)
        {
            _ruta = ruta;
        }

        public async Task <T> Get<T>(object search)
        {

            try
            {
                var url = $"{Properties.Settings.Default.APIUrl}/{_ruta}";

                if (search != null)
                {
                    url += "?";
                    url += await search.ToQueryString();
                }

                var result = await url.WithBasicAuth(username, pass).GetJsonAsync<T>();
                return result;
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show("Niste authentificirani!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.ServiceUnavailable)
                {
                    MessageBox.Show("Problemi sa serverom!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("Resurs ne postoji!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.InternalServerError)
                {
                    MessageBox.Show("Problemi sa serverom!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Forbidden)
                {
                    MessageBox.Show("Nemate pravo pristupa!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.BadRequest)
                {
                    MessageBox.Show("Greška napravljena prema serveru!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                return default(T);
            }

            }
        public async Task<T> GetById<T>(int ?id)
        {
            try
            {
                var url = $"{Properties.Settings.Default.APIUrl}/{_ruta}/{id}";
                var result = await url.WithBasicAuth(username, pass).GetJsonAsync<T>();
                return result;
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show("Niste authentificirani!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.ServiceUnavailable)
                {
                    MessageBox.Show("Problemi sa serverom!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("Resurs ne postoji!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.InternalServerError)
                {
                    MessageBox.Show("Problemi sa serverom!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Forbidden)
                {
                    MessageBox.Show("Nemate pravo pristupa!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.BadRequest)
                {
                    MessageBox.Show("Greška napravljena prema serveru!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                return default(T);

            }
        }

        public async Task<T> Insert<T>(object request)
        {
            try
            {
                var url = $"{Properties.Settings.Default.APIUrl}/{_ruta}";
                return await url.WithBasicAuth(username, pass).PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show("Niste authentificirani!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.ServiceUnavailable)
                {
                    MessageBox.Show("Problemi sa serverom!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("Resurs ne postoji!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.InternalServerError)
                {
                    MessageBox.Show("Problemi sa serverom!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Forbidden)
                {
                    MessageBox.Show("Nemate pravo pristupa!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.BadRequest)
                {
                    MessageBox.Show("Greška napravljena prema serveru!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                return default(T);

            }
        }

    
       
      

        public async Task<T>  Update<T>(int? id, object request)
        {
            try
            {
                var url = $"{Properties.Settings.Default.APIUrl}/{_ruta}/id?={id}";
                return  await url.WithBasicAuth(username, pass).PutJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show("Niste authentificirani!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.ServiceUnavailable)
                {
                    MessageBox.Show("Problemi sa serverom!", "Greška",  MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("Resurs ne postoji!", "Greška",  MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.InternalServerError)
                {
                    MessageBox.Show("Problemi sa serverom!", "Greška",  MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Forbidden)
                {
                    MessageBox.Show("Nemate pravo pristupa!", "Greška",  MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.BadRequest)
                {
                    MessageBox.Show("Greška napravljena prema serveru!", "Greška",  MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                return default(T);

            }

        }
        public async Task<HttpResponseMessage> Delete(object id)
        {
            try
            {
                var url = $"{Properties.Settings.Default.APIUrl}/{_ruta}/id?={id}";
                
                return await url.WithBasicAuth(username, pass).DeleteAsync();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show("Niste authentificirani!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.ServiceUnavailable)
                {
                    MessageBox.Show("Problemi sa serverom!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("Resurs ne postoji!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.InternalServerError)
                {
                    MessageBox.Show("Nemate pravo za izvršenje ove akcije, kontaktirajte administratora za više informacija!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Forbidden)
                {
                    MessageBox.Show("Nemate pravo pristupa!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.BadRequest)
                {
                    MessageBox.Show("Greška napravljena prema serveru!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                HttpResponseMessage http = new HttpResponseMessage();
                http.StatusCode = System.Net.HttpStatusCode.InternalServerError;
                return http;

            }
         

        }

      
    }
}
