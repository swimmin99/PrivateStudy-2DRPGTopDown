# DeepDive

<div align="center">
  
![header](https://capsule-render.vercel.app/api?type=waving&height=250&color=00ffff&text=DeepDive&fontColor=ffffff)
![header](https://capsule-render.vercel.app/api?type=rect&height=50&color=ebf3f5&text=기획서&fontColor=000000&fontSize=20)
<img src=https://user-images.githubusercontent.com/109887066/209663461-44fd8c3b-e485-48b9-94e8-515c97018a08.gif>

  <div align="left">
세상이 물에 빠져버렸다. 주인공은 살아남기 위해 자원의 보고인 바다로 뛰어들어야 한다! 교활한 바닷속 생물들을 취하고 바다의 비밀을 풀어보자!
망망대해에서 살아남은 생존자들과 힘을 합쳐 새로운 세상을 헤쳐나가보자~
    
플랫폼 : PC  
타겟 : 전연령대
장르 : 샌드박스 + 로그라이크 + rpg
구현기술 : 2D
전반적인 분위기 : 귀엽고 힐링

인터페이스 :
입력장치 키보드 마우스
게임화면의 메뉴형식

게임시작 : 플레이어가 시작과함께 할 수 있는 일
주변환경과 인터랙팅, 사냥, 낚시, 크래프팅

목적 : 자신의 배를 보완시켜서 주변과 커넥팅

등장요소 : 플레이어 캐릭터, 몬스터(어류), npc(타 배의 선장), 상인

게임요소/아이템 : 각종 크래프팅 가능한 아이템, 창(스피어), 낚시대

맵/건물/맵오브젝트
바다, 배(여러종류), 타 npc, 몬스터(어류)

규칙
게임플레이 방법과 관련된 규칙

게임플레이
제시된 규칙에 따라 플레이어가 취할 수 있느 행동
상호작용

레벨 디자인
각 스테이지에서 레벨을 조정하는 방법
수심이 달라질수록 난이도가 올라간다
  1)레벨 콘셉트 디자인 (전체적인 주제) 동해 앞바다 느낌
  2) 구조, 공간 디자인 - 사냥터 필드(해양 환경)
  3) 환경 배경 디자인 - 화려한 수중 환경 산호초
  4)레벨 스크립트 디자인 - 몬스터는 특정 구역에서 리젠, 조개형 몬스터는 함정형 몬스터 등

기술적 요구사항
몬스터 npc 등의 ai와 아이템 인터렉션 기술

마케팅
nearlly non existing at this point. to be added later
  <div align="center">

![header](https://capsule-render.vercel.app/api?type=rect&height=50&color=ebf3f5&text=플랜&fontColor=000000&fontSize=20)

---
|날짜|로그|자료|참고|
|---|---------|----|----|
|2022-12-10|플레이어 조작[^1]|<img src=https://user-images.githubusercontent.com/109887066/209662338-d395abd8-62c6-44b9-8aa0-bf713b731f40.gif>|[참고영상](https://www.youtube.com/watch?v=7iYWpzL9GkM&t=3610s)|
|2022-12-23|몬스터 추적|<img src=https://user-images.githubusercontent.com/109887066/209662509-13a3a3c4-adf2-46e7-9680-5bdf5682cdc4.gif>|[참고영상1](https://www.youtube.com/watch?v=8eWbSN2T8TE), [참고영상2](https://www.youtube.com/watch?v=MowE3moQ_Cw&t=577s)|
|2022-12-27|몬스터 넉백|<img src=https://user-images.githubusercontent.com/109887066/209662260-e484bcbb-7211-4dd5-946e-af47dc621240.gif>|[참고영상](https://youtu.be/8rTK68omQow)|
|2022-12-27|플레이어 넉백|<img src=https://user-images.githubusercontent.com/109887066/209662009-50948254-c251-48eb-a3e5-f4f0337b4e38.gif>|[참고영상](https://youtu.be/8rTK68omQow)|

|2023-01-15|인벤토리 및 ui|blank|
|2023-01-25|NPC 및 대화 시스템, 퀘스트 시스템|blank|
    

[^1]: 임시 스프라이트 출처 GAME ENDEAVOR : https://game-endeavor.itch.io/mystic-woods
---
    
![header](https://capsule-render.vercel.app/api?type=rect&height=50&color=ebf3f5&text=진척도&fontColor=000000&fontSize=20)
 
</div>

- [x] Plyaer Controller 구축 2022-12-01☑
- [x] Enemy type A 1) hp system 2022-12-02☑
- [x] Enemy type A 2) persuit player 2022-12-20☑
- [x] Enemy type A 3) random patrolling 2022-12-23☑
- [x] Enemy type A 4) player encounter interaction 2022-12-27
- [x] Enemy type A 5) knockback system 2022-12-27☑
- [ ] Damage UI, invincibility timer 

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
