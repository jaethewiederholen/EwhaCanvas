# jayjayjay  

## 🎨EWHA CANVAS🎨


## ⬇ 유튜브 채널 및 시현영상 Link ⬇  
https://youtu.be/VG1pc__RJrs<br><br><br>

## ⬇ Application Download Link ⬇

https://drive.google.com/file/d/1cpUEdgC10st_ZeIHd-Dhy36gntO0Y1kt/view?usp=sharing<br><br><br>
##  TODO list

### [전시회 기획 관련 작업]


#### ✅ 전시회 주제 고안<br>
#### ✅ 전시회 주제와 맞는 작가들 선별<br>
#### ✅ 작가들의 작품 중 전시할 작품 선별<br>
#### ✅ 작품 전시 구역 선정 <br>
#### ✅ 전시 구역 위도,경도 정확히 기록<br>
#### ✅ 작품 전시작 설명 작성<br>
#### ✅ 게이미피케이션 요소 고안<br><br><br><br>

### [Application 생성 작업]
#### - UX/UI 관련 작업<br>

#### ✅ 전시회 맵 생성<br>
#### ✅ 오프닝 씬 생성<br>
#### ✅ 전시회 구역을 나타내는 아이콘 생성<br>
#### ✅ 전시 안내 팝업 창 생성<br>
#### ✅ 다른 씬으로 이동하는 버튼 생성<br>
#### ✅ 게이미피케이션 요소 생성<br>
#### ✅ 작품 전시작 설명 이미지 생성<br><br><br>

#### - 개발 작업<br>

#### ✅ 유니티 안드로이드 환경에서 개발<br>
#### ✅ AR 마커인식 및 AR 오브젝트 생성 <br>
#### ✅ GPS 인식 및 GPS기반 AR오브젝트 생성 <br>
#### ✅ Marker AR + Markerless AR 병합 <br>
#### ✅ AR SDK 및 안드로이드 스튜디오 연동<br>
#### ✅ Toggle 기능 구현<br>
#### ✅ Player prefs으로 사용자 정보 저장<br>
#### ✅ AR 물체 터치와 관련된 interaction 작업 <br>
#### ✅ scene과 AR Camera간 전환 작업 <br>

<br>

## 프로젝트 repository 정리

#### 1.최종 완성본  
https://github.com/jaethewiederholen/EwhaCanvas

#### 2. 작품 사진 및 설명 모음 
https://github.com/jaethewiederholen/EwhaCanvas/tree/master/Assets/Resources

#### 3.게임시스템 및 AR Object 구현 관련 script 
https://github.com/jaethewiederholen/EwhaCanvas/tree/master/Assets/Scripts
<br><br>  
## 프로젝트의 목적<br>
### 캠퍼스 내에 체험형 야외 AR 미술관을 구현한다. <br>

##### 시범적으로 이화여대 학생들을 대상으로, 학생들의 일상적인 공간인 학교 캠퍼스에 야외 미술관 설치한다. <br>  전시는 모바일 AR 앱 형태로 제공하여 스마트폰만 소지하면 캠퍼스 공간 내에서 미술관 관람이 가능하도록 한다. 갤러리라는 물리적 공간의 제약을 없애고 학생들의 일상적인 공간 속에서 공간적 성격과 부합하는 미적체험을 제공한다는 점에서 새로운 가치를 가진다.<br> 또한 어플리케이션에 게임적 요소를 도입하여 게임을 통해 전시회를 관람하도록 하여 흥미와 집중도를 높였다. <br>이와같은 게이미피케이션 요소를 통해 사용자는 전시 작품 설명을 더 주의깊게 보고 배워갈 수 있다. AR기술을 활용한 인터렉션 요소와 공간 스토리텔링과 부합하는 게임 스토리텔링 전시를 통해 효과적인 관람을 유도할 계획이다.<br><br><br>

## 시나리오
#### 1. 어플리케이션에 접속, 게임 시작<br>
#### 2. 메뉴에서 원하는 구역 선택<br>
#### 3. 구역에 입장하기 전 지정된 작가 설명 읽기 <br>
#### 4. 화면에 표시되는 AR 작품을 관람할 위치로 이동하기<br>
#### 5. AR 작품이 나타나면 터치하여 작품 설명과 함께 작품 감상하기<br>
#### 6. AR 작품에 숨겨진 글자들을 찾아서  마커인식을 할 위치 찾아내기<br>
#### 7. 마커인식으로 여성 작가들의 조언과 아이템 획득하기!<br>
#### 8. 모든 구역에서 조언과 물품을 전부 획득했다면 map에  새롭게 열린 보너스 scene 구역으로 이동<br>
#### 9. 보너스 scene에서 나타나는 새로운 작품들 즐기기<br><br><br>
## 프로젝트 아키텍처
![KakaoTalk_Photo_2021-05-20-11-25-08](https://user-images.githubusercontent.com/71870316/118910493-820f3b00-b95f-11eb-9710-d56f7d48cf6a.jpeg)
<br><br><br>

## 관련 연구/서비스/시스템 조사 결과 및 한계점 

### 1.해외 사례 : 정부 차원의 사회적 정책 시행(갤러리 운영 활성화, 관람료 할인 등)<br>
 ##### 장점) 정책적으로 아티스트를 후원하고 사람들이 일상에서 쉽게 예술작품을 접할 수 있는 문화적 토양을 제공할 수 있다.<br>
 ##### 단점) 해외국가와 우리나라간의 문화적 환경의 차이가 존재하여 현실적으로 불가능한 부분이 많고, 재정적 부담이 존재한다.<br><br>
 
### 2.일상공간에 부분적 AR체험 제공(지하철역, 공원등에 AR스팟 제공)<br>
 ##### 장점) 미적체험의 접근성을 낮추고 미술관/전시회 등의 공간적 한계를 어느정도 극복하였다.<br>
 ##### 단점) AR을 체험하게 하는 유도 요인이 부족하여 낮은 참여율을 보인다. <br>또한 지하철역 등은 이동성이 높은 공간이어서 미적체험에 적합하지 않는 것을 보아 공간의 특성에 대한 고려가 부족하다.<br><br>
 
### 3.VR 미술관<br>
 ##### 장점) 공간적 한계를 거의 극복하였다.<br>
 ##### 단점) VR기기 소유가 일반적이지 않아 접근성이 떨어진다.<br>(미술관 안에서 제공하는 VR체험 같은 경우, VR기기가 제공되지만, 미술관에 가야 한다는 접근성의 문제는 해결되지 않는다.)<br><br>
## 구현 참고 자료
#### AR CORE SDK<br>
▪ https://github.com/google-ar/arcore-unity-sdk
#### Mapbox SDK<br>
▪ https://github.com/mapbox/mapbox-ar-unity
#### Unity AR System <br>
▪ https://github.com/needle-mirror/com.unity.xr.arsubsystems/commit/fd6a6a03159050fba8a28d5ba0fea5b159a9f05f<br>
▪ https://github.com/livedtrid/macao-unity/blob/a71769710d97716b7a9a686532db72beeb494e50/Assets/Samples/Assets/Common/Scripts/TouchController.cs<br>
▪ https://github.com/Burnsychocoes-dev/OpenCvSharp_FaceDetector/blob/2442593973316d9115f4e1ac460fae92f605999e/OpenCVSharp/Assets/Script/Buttons/RecordButton.cs<br>
▪ https://github.com/Burnsychocoes-dev/OpenCvSharp_FaceDetector/blob/2442593973316d9115f4e1ac460fae92f605999e/OpenCVSharp/Assets/Script/Buttons/ChangeSceneOnClickScript.cs<br>
▪ https://github.com/Lukasz199312/ClickCraft/blob/5d9af7b738b1f38014663a5905038657b01c4f70/Assets/Scripts/Clicker/ImagePixelBuild.cs<br>
