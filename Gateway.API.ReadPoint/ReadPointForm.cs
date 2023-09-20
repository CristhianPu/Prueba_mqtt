using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Gateway.Api.Api;
using Gateway.Api.Client;
using Gateway.Api.Model;
using System.Text;
using System.Threading.Tasks;
using MQTTnet.Client;
using MQTTnet;
using System.Net;
using System.Text.Json.Serialization;
using Microsoft.Azure.Devices.Client;
using Newtonsoft.Json;
using Microsoft.Azure.Amqp.Framing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Gateway.Api
{

    public partial class ReadPoint : Form
    {

        IDictionary<int, DataPointV1> m_pointsByID = null;    // All points with all information.
        public ReadPoint()
        {
            InitializeComponent();
  
        }

        // Declarar una lista para almacenar las variables en la listBox1
        List<string> todasLasVariables = new List<string>();
        // Declarar una lista para almacenar las variables en la listBox2
        List<string> todasLasVariables2 = new List<string>();


        private void buttonGetPoint_Click(object sender, EventArgs e)
        {

            //MQTT
            var mqttFactory = new MqttFactory();
            var mqttClient = mqttFactory.CreateMqttClient();

            var options = new MqttClientOptionsBuilder()
                .WithTcpServer("test.mosquitto.org", 1883) // Dirección y puerto del broker MQTT
                .WithClientId("MqttNetSender") // Identificador único del cliente
                .Build();

            

            // Configuring the username and password for the opening of the session.
            var configuration = new Client.Configuration(username: textBoxUsername.Text, password: textBoxPassword.Text);

            
            if (textBoxIPAddress.Text == "" || textBoxUsername.Text == "" || textBoxPassword.Text == "")
                toolStripStatusLabel.Text = "Falta la dirección IP, el nombre de usuario y/o la contraseña.";
            else
            {
                // Setting the base URL and the configuration for the API client. 
                var client = new ApiClient(configuration, "https://" + textBoxIPAddress.Text);
                var factory = new ApiFactory(client);


                // Initialize a Points API with the previous settings.
                var api = factory.CreateApiDataPointsV1();

                if (m_pointsByID == null)
                {
                    // Get information for all points
                    m_pointsByID = api.ListAll(true).ToDictionary(p => p.ID.Value);

                    textBoxIPAddress.Enabled = false;
                    textBoxUsername.Enabled = false;
                    textBoxPassword.Enabled = false;
                   
                }
             
                    //Get all the points and his names and his values 
                    var pointByIDs = api.ListAll(details: true).ToDictionary(p => p.ID.Value);
                    foreach(var item in pointByIDs)
                    {
                         string id = item.Value.Name.ToString();
                         string valor = item.Value.Value.ToString();
                        // textBoxPointInfo.Paste(id + ": " + valor + Environment.NewLine);
                        checkedListBox1.Items.Add(id + ": " + valor + Environment.NewLine);
                    }
                    checkedListBox1.ItemCheck += (s, ev) =>
                    {
                        // Obtener el índice del elemento marcado o desmarcado
                        int selectedIndex = ev.Index;
                        string variable = checkedListBox1.Items[selectedIndex].ToString();

                        // Verificar si el elemento se marcó (Checked) o desmarcó (Unchecked)
                        if (ev.NewValue == CheckState.Checked)
                        {

                            textBoxCheckPoints.Paste(variable);


                        }
                        else if (ev.NewValue == CheckState.Unchecked)
                        {
                            string textoActual = textBoxCheckPoints.Text;
                            string textoModificado = textoActual.Replace(variable, string.Empty);
                            textoModificado = textoModificado.Trim();
                            textBoxCheckPoints.Text = textoModificado;
                            


                        }
                    };

                    toolStripStatusLabel.Text = "Tarea realizada";
            
            }
        }

        private void radioButtonDynamicData_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ReadPoint_Load(object sender, EventArgs e)
        {



        }

        private void textBoxPointInfo_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // Add data retated to yout IoTConnection
        string deviceKey = "<wDbWMPwMbZJYU0Qo0e+KBAiNcpjxt47TqGOFGPKSwU8=>";
        string deviceId = "<SMPGateway>";
        string iotHubHostName = "<IoTHubHostname>";
        


        private void buttonConnect_Click(object sender, EventArgs e)
        {
            var deviceAuthentication = new DeviceAuthenticationWithRegistrySymmetricKey(deviceId, deviceKey);

            DeviceClient deviceClient = DeviceClient.Create(iotHubHostName, deviceAuthentication, Microsoft.Azure.Devices.Client.TransportType.Mqtt);


            while (true)
            {
                double currentTemperature = 20;
                double currentHumidity = 60;
                var telemetryDataPoint = new
                {
                    //messageId = _messageId++,
                    //deviceId = deviceId,
                    temperature = currentTemperature,
                    humidity = currentHumidity
                };
                string messageString = JsonConvert.SerializeObject(telemetryDataPoint);
                Microsoft.Azure.Devices.Client.Message message = new Microsoft.Azure.Devices.Client.Message(Encoding.ASCII.GetBytes(messageString));
                message.Properties.Add("temperatureAlert", (currentTemperature > 30) ? "true" : "false");

                try
                {
                    deviceClient.SendEventAsync(message).Wait(); // Espera síncrona para enviar el mensaje
                  //  Console.WriteLine("Mensaje enviado al IoT Hub con éxito.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al enviar el mensaje: {ex.Message}");
                }
                finally
                {
                    deviceClient.CloseAsync().Wait(); // Espera síncrona para cerrar el cliente
                }



            }

            /*String Address = textBoxIPAddressMQTT.Text;
            int port = int.Parse(textBoxPortMQTT.Text);
            String ID = textBoxIdMQTT.Text;
            String stringMQTT = textBoxStingMQTT.Text;
            String Points = textBoxCheckPoints.Text;

            var mqttFactory = new MqttFactory();
            var mqttClient = mqttFactory.CreateMqttClient();

            var options = new MqttClientOptionsBuilder()
                .WithTcpServer(Address, port) // Dirección y puerto del broker MQTT
                .WithClientId(ID) // Identificador único del cliente
                .Build();

            mqttClient.ConnectAsync(options).Wait(); // Conexión síncrona

            // Canal específico en Node-RED
            string channel = ID;
            // Mensaje a enviar
            
            string message = Points;

            var mqttMessage = new MqttApplicationMessageBuilder()
                .WithTopic(channel)
                .WithPayload(message)
                .WithQualityOfServiceLevel(MQTTnet.Protocol.MqttQualityOfServiceLevel.AtMostOnce)
                .WithRetainFlag(false)
                .Build();

            mqttClient.PublishAsync(mqttMessage).Wait(); // Publicación síncrona

            mqttClient.DisconnectAsync().Wait(); // Desconexión síncrona*/
        }
    }
}
