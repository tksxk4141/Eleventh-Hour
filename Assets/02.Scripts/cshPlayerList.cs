using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class cshPlayerList : MonoBehaviourPunCallbacks
{
    public TMP_Text text;
    Player player;//포톤 리얼타임은 Player를 선언 할 수 있게 해준다.

    public void SetUp(Player _player)
    {
        player = _player;
        text.text = _player.NickName;//플레이어 이름 받아서 그사람 이름이 목록에 뜨게 만들어준다. 
    }

    public void SetUpFriends(string friend)
    {
        text.text = friend;//플레이어 이름 받아서 그사람 이름이 목록에 뜨게 만들어준다. 
    }

    public override void OnPlayerLeftRoom(Player otherPlayer)//플레이어가 방떠났을때 호출
    {
        if (player == otherPlayer)//나간 플레이어가 나면?
        {
            Destroy(gameObject);//이름표 삭제
        }
    }

    public override void OnLeftRoom()//방 나가면 호출
    {
        Destroy(gameObject);//이름표 호출
    }
    
}

