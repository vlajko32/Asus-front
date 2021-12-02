using Asus.CoreBusiness.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using static System.Net.WebRequestMethods;

namespace Asus.CoreBusiness.Service
{
    public class ApiService
    {
        internal static string BaseUrl = "http://localhost:20187/api/";

        public static List<Trziste> GetTrzista()
        {
            try
            {
                ApiHelper.InitializeClient();
                HttpResponseMessage message = ApiHelper.httpClient.GetAsync($"{BaseUrl}trzista").Result;
                if (message.IsSuccessStatusCode)
                {
                    try
                    {
                        return message.Content.ReadAsAsync<List<Trziste>>().Result;
                    }
                    catch (Exception e)
                    {
                        throw new Exception(e.Message);
                    }
                }
                else
                {
                    throw new Exception(message.ReasonPhrase);
                }
            }
            catch
            {
                throw new Exception("Greska u komunikaciji sa bazom!");
            }
        }

        public static bool IzmeniRadnika(Radnik radnik, int id)
        {
            ApiHelper.InitializeClient();
            try
            {
                HttpResponseMessage message = ApiHelper.httpClient.PutAsJsonAsync($"{BaseUrl}radnik/{id}", radnik).Result;
                if (message.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static bool ObrisiRadnika(int id)
        {
            ApiHelper.InitializeClient();
            try
            {
                HttpResponseMessage message = ApiHelper.httpClient.DeleteAsync($"{BaseUrl}radnik/{id}").Result;
                if (message.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static bool ObrisiPorudzbenicu(int id)
        {
            ApiHelper.InitializeClient();
            try
            {
                HttpResponseMessage message = ApiHelper.httpClient.DeleteAsync($"{BaseUrl}porudzbeenica/{id}").Result;
                if (message.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static Porudzbenica VratiPorudzbenicu(int sifraPorudzbenice)
        {
            ApiHelper.InitializeClient();
            try
            {
                HttpResponseMessage message = ApiHelper.httpClient.GetAsync($"{BaseUrl}porudzbeenica/{sifraPorudzbenice}").Result;
                if (message.IsSuccessStatusCode)
                {
                    try
                    {
                        return message.Content.ReadAsAsync<Porudzbenica>().Result;
                    }
                    catch (Exception e)
                    {
                        throw new Exception(e.Message);
                    }
                }
                else
                {
                    throw new Exception(message.ReasonPhrase);
                }
            }
            catch
            {
                throw new Exception("Greska u komunikaciji sa bazom!");
            }
        }

        public static bool KreirajPorudzbenicu(Porudzbenica porudzbenica)
        {
            ApiHelper.InitializeClient();
            try
            {
                HttpResponseMessage message = ApiHelper.httpClient.PostAsJsonAsync($"{BaseUrl}porudzbeenica/create", porudzbenica).Result;
                if (message.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static Proizvod VratiProizvod(int sifraProizvoda)
        {
            ApiHelper.InitializeClient();
            try
            {
                HttpResponseMessage message = ApiHelper.httpClient.GetAsync($"{BaseUrl}proizvod/{sifraProizvoda}").Result;
                if (message.IsSuccessStatusCode)
                {
                    try
                    {
                        return message.Content.ReadAsAsync<Proizvod>().Result;
                    }
                    catch (Exception e)
                    {
                        throw new Exception(e.Message);
                    }
                }
                else
                {
                    throw new Exception(message.ReasonPhrase);
                }
            }
            catch
            {
                throw new Exception("Greska u komunikaciji sa bazom!");
            }
        }

        public static Kupac PronadjiKupca(string piB)
        {
            ApiHelper.InitializeClient();
            try
            {
                HttpResponseMessage message = ApiHelper.httpClient.GetAsync($"{BaseUrl}kupac/{piB}").Result;
                if (message.IsSuccessStatusCode)
                {
                    try
                    {
                        return message.Content.ReadAsAsync<Kupac>().Result;
                    }
                    catch (Exception e)
                    {
                        throw new Exception(e.Message);
                    }
                }
                else
                {
                    throw new Exception(message.ReasonPhrase);
                }
            }
            catch
            {
                throw new Exception("Greska u komunikaciji sa bazom!");
            }
        }

        public static bool KreirajRadnik(Radnik Radnik)
        {
            ApiHelper.InitializeClient();
            try
            {
                HttpResponseMessage message = ApiHelper.httpClient.PostAsJsonAsync($"{BaseUrl}radnik/create", Radnik).Result;
                if(message.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static Radnik PronadjiRadnika(int id)
        {
            ApiHelper.InitializeClient();
            try
            {
                HttpResponseMessage message = ApiHelper.httpClient.GetAsync($"{BaseUrl}radnik/{id}").Result;
                if (message.IsSuccessStatusCode)
                {
                    try
                    {
                        return message.Content.ReadAsAsync<Radnik>().Result;
                    }
                    catch (Exception e)
                    {
                        throw new Exception(e.Message);
                    }
                }
                else
                {
                    throw new Exception(message.ReasonPhrase);
                }
            }
            catch
            {
                throw new Exception("Greska u komunikaciji sa bazom!");
            }
        }

        public static bool IzmeniPorudzbenicu(Porudzbenica porudzbenica, int id)
        {
            ApiHelper.InitializeClient();
            try
            {
                HttpResponseMessage message = ApiHelper.httpClient.PutAsJsonAsync($"{BaseUrl}porudzbeenica/{id}", porudzbenica).Result;
                if (message.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
