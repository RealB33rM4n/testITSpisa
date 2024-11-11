using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace GRAL.Networking {
	
	[System.Serializable]
    public class PM_RacersDatabaseModel {

        //tipo logico di player
        public PM_RacerType racerType;
        //id del team di appartenenza
        public string team;
        //nome del pilota
        public string pilotName;
        //nome del prefab della amcchina deve esistere in " Prefabs/Cars/"
        public string prefabName;
        //L'abilità di guida del pilota
        public string carName;
        //L'abilità di guida del pilota
        public int AI_PilotAbility;
        //L'aggressività con i powerUp
        public int AI_PilotAggressivity;
        // il punteggio delle gare precedenti
        public int Score;

     

        public Color color;

        //associated lobby player
        public GNLobbyPlayer lobbyPlayer;

    }

	public class SyncListRacers : SyncList<PM_RacersDatabaseModel> {

		protected override void SerializeItem (NetworkWriter writer, PM_RacersDatabaseModel item)
		{
			if(item == null){
				writer.Write(false);
				return;
			}
			writer.Write(true);
			writer.Write((byte)item.racerType);
			writer.Write(item.team);
			writer.Write(item.pilotName);
			writer.Write(item.prefabName);
			writer.Write(item.carName);
			writer.Write(item.AI_PilotAbility);
			writer.Write(item.AI_PilotAggressivity);
			writer.Write(item.Score);
			writer.Write(item.color);
			if (item.lobbyPlayer!= null) {
				writer.Write (true);
				writer.Write (item.lobbyPlayer.GetComponent<NetworkIdentity> ());
			} else {
				writer.Write (false);
			}

		}

		protected override PM_RacersDatabaseModel DeserializeItem (NetworkReader reader)
		{
			if(reader.ReadBoolean()){
				PM_RacersDatabaseModel item = new PM_RacersDatabaseModel();
				item.racerType = (PM_RacerType)reader.ReadByte();
				item.team = reader.ReadString();
				item.pilotName = reader.ReadString();
				item.prefabName = reader.ReadString();
				item.carName = reader.ReadString();
				item.AI_PilotAbility = reader.ReadInt32();
				item.AI_PilotAggressivity = reader.ReadInt32();
				item.Score = reader.ReadInt32();
				item.color = reader.ReadColor();
				if (reader.ReadBoolean()) {
					NetworkIdentity netid = reader.ReadNetworkIdentity ();
					item.lobbyPlayer = netid ? netid.GetComponent<GNLobbyPlayer> () : null;
				} else {
					item.lobbyPlayer = null;
				}
				return item;
			}

			return null;
		}

		public static implicit operator List<PM_RacersDatabaseModel>(SyncListRacers self){
			return new List<PM_RacersDatabaseModel>(self);
		}
	}
}
