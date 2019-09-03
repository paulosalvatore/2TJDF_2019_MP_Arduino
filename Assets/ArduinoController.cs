using System;
using System.Collections;
using System.IO.Ports;
using UnityEngine;

public class ArduinoController : MonoBehaviour
{
    private SerialPort arduinoSerialPort;
    public string port = "COM3";
    public int baudRate = 9600;

    private void Awake()
    {
        try
        {
            arduinoSerialPort = new SerialPort(port, baudRate)
            {
                ReadTimeout = 100
            };

            arduinoSerialPort.Open();

            StartCoroutine(ProcessData());
        }
        catch (Exception e)
        {
            Debug.LogError("Erro ao abrir porta: " + e);
        }
    }

    private IEnumerator ProcessData()
    {
        while (true)
        {
            yield return new WaitForEndOfFrame();

            try
            {
                string result = arduinoSerialPort.ReadLine();
                //Debug.Log("Leitura Arduino: " + result);

                string[] resultData = result.Split(';');

                string firstButton = resultData[0];
                Debug.Log("Primeiro botão: " + firstButton);
            }
            catch (Exception e)
            {
                //Debug.LogError("Erro ao processar dados: " + e);
            }
        }
    }
}