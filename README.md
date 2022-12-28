# DeepDive

<div align="center">
  
![header](https://capsule-render.vercel.app/api?type=waving&height=250&color=00ffff&text=🐠Deep⛵Dive🐟&fontColor=ffffff)
![header](https://capsule-render.vercel.app/api?type=rect&height=50&color=ebf3f5&text=기획서&fontColor=000000&fontSize=20)
  
🦦  🐟  🐠  🐡  🦈 ⛵ 🍤  🍥  🦐  🎏  🎣
</div>
  <div align="left">

```
세상이 물에 잠겨버렸다. 주인공은 살아남기 위해 자원의 보고인 바다로 뛰어들어야 한다! 교활한 바닷속 생물들을 취하고 바다의 비밀을 풀어보자!
망망대해에서 살아남은 생존자들과 힘을 합쳐 새로운 세상을 헤쳐나가보자~
```  
```
플랫폼 : PC  
타겟 : 전연령대
장르 : 샌드박스 + 로그라이크 + rpg
뷰 : 탑뷰/물 속에서 사냥시에도 탑뷰형식 유지!
전반적인 분위기 : 귀여운 아트 디자인과 힐링을 표방하나 하드한 요소를 부분적으로 포함함.
인터페이스 :
입력장치 키보드 마우스
게임화면의 메뉴형식
```
```
게임시작 : 플레이어가 시작과함께 할 수 있는 일
주변환경과 인터랙팅, 사냥, 낚시, 크래프팅
```
```
목적 : 자신의 배를 보완시켜서 생존, 주변과 커넥팅
등장요소 : 플레이어 캐릭터, 몬스터(어류), npc(타 배의 선장), 상인
게임요소/아이템 : 각종 크래프팅 가능한 아이템, 창(스피어), 낚시대

맵/건물/맵오브젝트
바다, 배(여러종류), 타 npc, 몬스터(어류)
```
```
규칙
밤낮 사이클 존재, 주인공의 상태는 체력(전투)과 기력(생활 행동)으로 나뉘어짐.
시간이 지날수록 파도 혹은 날씨의 환경이 플레이어에게 적대적으로 변함.


게임플레이
한정된 시간을 사용하여 빠르게 자급자족 생활을 완성하고 다른 생존자들과 커넥팅을 해야함.
자원을 얻기위해 하는 행동은 크게 사냥, 채집, 가공으로 나누어짐.
사냥은 바닷속 필드에서의 전투로 나타나고 게임플레이의 가장 큰 부분을 차지함. 채집은 이때 부가적인 요소임.
사냥과 채집으로 얻은 자원을 제작 시스템을 통해 가공하여 최종적으로 사용함.

  
상호작용

레벨 디자인
각 스테이지에서 레벨을 조정하는 방법
수심이 달라질수록 난이도가 올라간다
  1)레벨 콘셉트 디자인 (전체적인 주제) 동해 앞바다 느낌
  2) 구조, 공간 디자인 - 사냥터 필드(해양 환경)
  3) 환경 배경 디자인 - 화려한 수중 환경 산호초
  4)레벨 스크립트 디자인 - 몬스터는 특정 구역에서 리젠, 조개형 몬스터는 함정형 몬스터 등
```
```
기술적 요구사항
```
```
마케팅

```


</div>
<div align="center">

![header](https://capsule-render.vercel.app/api?type=rect&height=50&color=ebf3f5&text=개발로그&fontColor=000000&fontSize=20)

---
|날짜|로그|자료|참고|
|---|---------|----|----|
|2022-12-10|플레이어 조작[^1]|<img src=https://user-images.githubusercontent.com/109887066/209662338-d395abd8-62c6-44b9-8aa0-bf713b731f40.gif>|[참고영상](https://www.youtube.com/watch?v=7iYWpzL9GkM&t=3610s)|
|2022-12-23|몬스터 추적|<img src=https://user-images.githubusercontent.com/109887066/209662509-13a3a3c4-adf2-46e7-9680-5bdf5682cdc4.gif>|[참고영상1](https://www.youtube.com/watch?v=8eWbSN2T8TE), [참고영상2](https://www.youtube.com/watch?v=MowE3moQ_Cw&t=577s)|
|2022-12-27|몬스터 넉백|<img src=https://user-images.githubusercontent.com/109887066/209666044-97a0eadd-db41-46de-a1d5-167b82fae0ff.gif>|[참고영상](https://youtu.be/8rTK68omQow)|
|2022-12-27|플레이어 넉백|<img src=https://user-images.githubusercontent.com/109887066/209662009-50948254-c251-48eb-a3e5-f4f0337b4e38.gif>|[참고영상](https://youtu.be/8rTK68omQow)|

|2023-01-15|인벤토리 및 ui|blank|
|2023-01-25|NPC 및 대화 시스템, 퀘스트 시스템|blank|
    


    
![header](https://capsule-render.vercel.app/api?type=rect&height=50&color=ebf3f5&text=진척도&fontColor=000000&fontSize=20)
 
</div>

- [x] Plyaer Controller 구축 2022-12-01☑
- [x] Enemy type A 1) hp system 2022-12-02☑
- [x] Enemy type A 2) persuit player 2022-12-20☑
- [x] Enemy type A 3) random patrolling 2022-12-23☑
- [x] Enemy type A 4) player encounter interaction 2022-12-27
- [x] Enemy type A 5) knockback system 2022-12-27☑
- [x] Damage UI, invincibility timer 2022-12-28☑

- [ ] Enemy type A 4) item drop 
- [ ] Enemy type B 1) long distance attack
- [ ] Inventory System
- [ ] Conversation System
- [ ] interactive item (box)
- [ ] Map transportation portal
---
<p align = "left">
<img src="https://img.shields.io/badge/Unity-000000?style=flat-square&logo=Unity&logoColor=white"/></a>&nbsp
<img src="https://img.shields.io/badge/C Sharp-239120?style=flat-square&logo=C Sharp&logoColor=white"/></a>&nbsp
<img src="https://img.shields.io/badge/Aseprite-7D929E?style=flat-square&logo=Aseprite&logoColor=white"/></a>&nbsp
<img src="https://img.shields.io/badge/Visual Studio Code-007ACC?style=flat-square&logo=Visual Studio Code&logoColor=white"/></a>&nbsp
<img src="https://img.shields.io/badge/Visual-Studio-5C2D91?style=flat-square&logo=Visual-Studio&logoColor=white"/></a>&nbsp<br>
</p>
</div>
  <div align="center">
🦦  🐟  🐠  🐡  🦈 ⛵ 🍤  🍥  🦐  🎏  🎣

[^1]: 임시 스프라이트 출처 GAME ENDEAVOR : https://game-endeavor.itch.io/mystic-woods
[^2]: 임시 폰트 출처 GAME ENDEAVOR :Neo둥근모 Pro Copyright © 2017-2022, Eunbin Jeong (Dalgona.) <project-neodgm@dalgona.dev> with reserved font name "Neo둥근모 Pro" and "NeoDunggeunmo Pro".
---
