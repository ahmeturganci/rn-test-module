
# react-native-nfc-picc-manager

## Getting started

`$ npm install react-native-nfc-picc-manager --save`

### Mostly automatic installation

`$ react-native link react-native-nfc-picc-manager`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-nfc-picc-manager` and add `RNNfcPiccManager.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNNfcPiccManager.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNNfcPiccManagerPackage;` to the imports at the top of the file
  - Add `new RNNfcPiccManagerPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-nfc-picc-manager'
  	project(':react-native-nfc-picc-manager').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-nfc-picc-manager/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-nfc-picc-manager')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNNfcPiccManager.sln` in `node_modules/react-native-nfc-picc-manager/windows/RNNfcPiccManager.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Nfc.Picc.Manager.RNNfcPiccManager;` to the usings at the top of the file
  - Add `new RNNfcPiccManagerPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNNfcPiccManager from 'react-native-nfc-picc-manager';

// TODO: What to do with the module?
RNNfcPiccManager;
```
  