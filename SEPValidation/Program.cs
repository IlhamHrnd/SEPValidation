using SEPValidation.Helper;
using SEPValidation.RestAPI.Registration;
using SEPValidation.RestAPI.VClaim20;
internal class Program
{
    private static async Task Main(string[] args)
    {
        var guarantorID = "G-00001";
        var dateTime = DateHelper.DateTimeNow();
        var startDate = DateHelper.DateTimeNowDate(dateTime.Year, dateTime.Month, dateTime.Day);
        var endDate = DateHelper.DateTimeNowDate(dateTime.Year, dateTime.Month, dateTime.Day);
        var regist = await GetRegistrationPerDay.RegistrationPerDay(startDate, endDate, false);
        if (regist.Count > 0)
        {
            for (int i = 0; i < regist.Count; i++)
            {
                try
                {
                    var value = regist[i];
                    if (value.guarantorID == guarantorID)
                    {
                        Console.WriteLine($"{i + 1}. {value.registrationNo}");
                        Console.WriteLine(value.bpjsSepNo);
                        var sep = await GetSEP.VClaimSEPValidation(value.bpjsSepNo);
                        if (sep.metaData == null)
                        {
                            Console.WriteLine($"Metadata Is Null");
                        }
                        else if (!(bool)sep.metaData.isValid)
                        {
                            startDate = DateHelper.DateTimeAddDays(-3);
                            endDate = DateHelper.DateTimeAddDays(3);

                            string startDateString = DateHelper.DateTimeNow(DateHelper.DateStringFormat.Yearmonthdate, startDate);
                            string endDateString = DateHelper.DateTimeNow(DateHelper.DateStringFormat.Yearmonthdate, endDate);

                            var histori = await GetDataHistoriPelayananPeserta.PostPatientHistory(value.guarantorCardNo, startDateString, endDateString);
                            if (histori.response == null)
                            {
                                Console.WriteLine($"Riwayat Pasien Kosong");
                            }
                            else if (histori.metaData == null)
                            {
                                Console.WriteLine($"Metadata Is Null");
                            }
                            else if (histori.response.histori.Count > 0)
                            {
                                var lastHistory = histori.response.histori.FirstOrDefault();
                                var tglRegistration = DateHelper.DateTimeNow(DateHelper.DateStringFormat.Yearmonthdate, (DateTime)value.registrationDate);
                                var body = new SEPValidation.Model.Registration.PatchSEPRegistration
                                {
                                    registrationNo = value.registrationNo,
                                    bpjsSepNo = lastHistory.noSep,
                                    lastUpdateDateTime = dateTime,
                                    lastUpdateByUserID = "TarAviAPI"
                                };
                                switch (value.srRegistrationType)
                                {
                                    case "OPR":
                                        if (tglRegistration == lastHistory.tglSep && lastHistory.jnsPelayanan == "2")
                                        {
                                            var opr = await PatchSEPRegistration.PatchSEPRegistrationNo(body);
                                            if (!string.IsNullOrEmpty(opr))
                                            {
                                                Console.WriteLine($"{opr}/{lastHistory.jnsPelayanan}");
                                            }
                                        }
                                        else if (lastHistory.jnsPelayanan != "2")
                                        {
                                            Console.WriteLine($"Jenis Pelayanan {lastHistory.jnsPelayanan} Tidak Sesuai");
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Tanggal SEP Tidak Sesuai. Tanggal Registrasi : {tglRegistration}, Tanggal SEP : {lastHistory.tglSep}");
                                        }
                                        break;

                                    case "EMR":
                                        if (tglRegistration == lastHistory.tglSep && lastHistory.jnsPelayanan == "2")
                                        {
                                            var emr = await PatchSEPRegistration.PatchSEPRegistrationNo(body);
                                            if (!string.IsNullOrEmpty(emr))
                                            {
                                                Console.WriteLine($"{emr}/{lastHistory.jnsPelayanan}");
                                            }
                                        }
                                        else if (lastHistory.jnsPelayanan != "2")
                                        {
                                            Console.WriteLine($"Jenis Pelayanan {lastHistory.jnsPelayanan} Tidak Sesuai");
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Tanggal SEP Tidak Sesuai. Tanggal Registrasi : {tglRegistration}, Tanggal SEP : {lastHistory.tglSep}");
                                        }
                                        break;

                                    case "IPR":
                                        var tglSEP = Converter.StringToDateTime(lastHistory.tglSep, dateTime);
                                        int compareDateTime = DateTime.Compare((DateTime)value.registrationDate, tglSEP);
                                        if (compareDateTime <= 1 && compareDateTime >= 0 && lastHistory.jnsPelayanan == "1")
                                        {
                                            var ipr = await PatchSEPRegistration.PatchSEPRegistrationNo(body);
                                            if (!string.IsNullOrEmpty(ipr))
                                            {
                                                Console.WriteLine($"{ipr}/{lastHistory.jnsPelayanan}");
                                            }
                                        }
                                        else if (lastHistory.jnsPelayanan != "1")
                                        {
                                            Console.WriteLine($"Jenis Pelayanan {lastHistory.jnsPelayanan} Tidak Sesuai");
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Tanggal SEP Tidak Sesuai. Tanggal Registrasi : {tglRegistration}, Tanggal SEP : {lastHistory.tglSep}");
                                        }
                                        break;

                                    case "MCU":
                                        Console.WriteLine($"{value.srRegistrationType} Tidak Ada BPJS");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine(histori.metaData.message);
                            }
                        }
                        else
                        {
                            Console.WriteLine(sep.metaData.message);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        else
        {
            Console.WriteLine($"No Registration Found");
        }
        Console.ReadLine();
    }
}