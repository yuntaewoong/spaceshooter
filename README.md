# spaceshooter
-------------
![screenshot 1](https://user-images.githubusercontent.com/38284288/40920521-ca0c450e-6847-11e8-96c3-9a72255a9de1.png)  
screenshot1 게임 실행시 화면  
prefab으로 설정된 소행성들이 맨윗줄 랜덤한 위치에서 생성되어 날아온다.  
이때 소행성 오브젝트들이 쌓이면 과부하가 걸릴 수 있기 때문에 화면 바깥쪽에 collider를 설정하여  
collider를 넘어선 소행성들이 삭제되도록 설정하였다.
![screenshot_2](https://user-images.githubusercontent.com/38284288/40920637-1c997b0c-6848-11e8-9550-60e15751f6c0.png)  
screenshot2 소행성 파괴  
소행성은 우주선의 광선 prefab들과 충돌시 터지는 효과를 출력하고  
화면의 score텍스트의 score값을 10늘린다.  
![screenshot_3](https://user-images.githubusercontent.com/38284288/40920682-437668fc-6848-11e8-9519-7bc4a6f3412a.png)  
screenshot3 우주선 파괴  
우주선의 collider에 소행성이 닿으면 우주선이 파괴된다.  
mesh collider나 box collider를 사용할 수 있는데  
최적화를 위해서는 box collider를 정확함을 위해서는 mesh collider를 사용한다.  
비교적 간단한 게임이기에 mesh collider를 사용했다.  
![screenshot 4](https://user-images.githubusercontent.com/38284288/40920723-5c6aff12-6848-11e8-9303-d917c34c0e72.png)  
screenshot4 우주선 파괴이후 gameover화면  
우주선이 파괴되면 바로 gameover 텍스트가 출력되고  
이후 소행성들이 화면주위의 collider에 의해 모두 사라지면  
R버튼을 눌러 다시 시작할 것인지를 묻는 text가 오른쪽 위에 나타난다.  
R키를 누를 시 처음 게임을 시작했던 때와 같이 게임이 다시 시작된다.  
