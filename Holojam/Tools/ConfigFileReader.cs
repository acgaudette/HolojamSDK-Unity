// ConfigFileReader.cs
// Created by Holojam Inc. on 03.04.17

using UnityEngine;
using System.Xml;
using System.IO;
using Holojam.Network;

namespace Holojam.Tools {
  public class ConfigFileReader : MonoBehaviour {
    public string configFilePath = "./config.xml";

    void Awake() {
      LoadConfiguration();
    }

    void LoadConfiguration() {
      XmlDocument configFile = new XmlDocument();
      try {
        configFile.Load(configFilePath);
      }
      catch (FileNotFoundException) {
        Debug.LogWarning("Holojam configuration file at " + configFilePath + " not found.");
        return;
      }
      catch (XmlException ex) {
        Debug.LogWarning("Error reading Holojam configuration file: " + ex.Message);
        return;
      }

      foreach (XmlNode node in configFile.DocumentElement.ChildNodes) {
        switch (node.Name) {
        case "RelayIP":
          Client client = GetComponent<Client>();
          if (client == null) {
            Debug.LogWarning("Error: Holojam ConfigFileReader should be added to the same GameObject "
                             + " as the Holojam Client.");
            break;
          }
          string ip = GetText(node);
          // TODO: maybe validate the build IP
          client.ChangeRelayAddress(ip);
          break;
        case "BuildIndex":
          string buildIndexText = GetText(node);
          int buildIndex = -1;
          if (!int.TryParse(buildIndexText, out buildIndex)) {
            Debug.LogWarning("Error in Holojam configuration file: build index should be a number,"
                             + " instead got \"" + buildIndexText + "\".");
            break;
          }
          BuildManager.BUILD_INDEX = buildIndex;
          break;
        default:
          Debug.LogWarning("Unknown option \"" + node.Name
                           + "\" found in Holojam config file at " + configFilePath);
          break;
        }
      }
    }

    string GetText(XmlNode node) {
      foreach (XmlNode child in node.ChildNodes) {
        if (child.NodeType == XmlNodeType.Text) {
          return child.Value;
        }
      }
      return null;
    }
  }
};