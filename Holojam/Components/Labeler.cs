using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Holojam.Components {

  /// <summary>
  /// Static class granting access to a singleton labeler instance (NOTE: Feel
  /// free to disagree with this design choice), which generates labels upon
  /// request.
  /// </summary>
  public static class Labeler {

    public class LabelerInstance {

      private readonly IDictionary<string, int> collisionMap;
      private readonly IDictionary<int, string> idMap;

      internal LabelerInstance() {
        collisionMap = new Dictionary<string, int>();
        idMap = new Dictionary<int, string>();
      }

      /// <summary>
      /// Given a GameObject, generate and return a unique label
      /// </summary>
      public string GetLabel(Holojam.Network.Controller obj) {
        int id = obj.GetInstanceID();
        string label;
        if (idMap.TryGetValue(id, out label)) {
          return label;
        }

        string gName = obj.gameObject.name;
        int count = 0;
        // If the key exists, increase the count before updating the dictionary
        if (collisionMap.TryGetValue(gName, out count)) {
          count++;
        }

        collisionMap[gName] = count;

        // label is concatenation of the name with count
        return idMap[id] = gName + ':' + count;
      }
    }
    
    private static LabelerInstance instance;

    // <summary>
    // wrapper for internal instance method, GenerateLabel,
    // returns a new label upon request
    // </summary>
    public static string GetLabel(Holojam.Network.Controller obj) {
      if (instance == null) {
        instance = new LabelerInstance();
      }
      return instance.GetLabel(obj);
    }
  }

}
