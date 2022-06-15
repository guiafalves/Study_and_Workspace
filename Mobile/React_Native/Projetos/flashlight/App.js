import React, {useState, useEffect} from 'react';
import {View, StyleSheet, Image, TouchableOpacity} from 'react-native';
import Torch from 'react-native-torch'
import RNShake from 'react-native-shake'

const App = () => {
  const [toggle, setToggle] = useState(false); //false

  const handleChangeToggle = ()=>setToggle(oldToggle => !oldToggle);
  
  useEffect(()=> {
    Torch.switchState(toggle);
  }, [toggle]);

  useEffect(()=>{
    const subscription = RNShake.addListener(()=>{
      setToggle(oldToggle => !oldToggle);
    });
    return () => subscription.remove();
  }, []);

  return (
    <View style={toggle ? style.containerLigth : style.container } >
      <TouchableOpacity onPress={handleChangeToggle}>
    <Image 
      style={toggle  
        ? style.ligthingOn
        : style.ligthingOff}
      source={toggle 
        ? require('./assets/icons/logocolor.png') 
        : require('./assets/icons/imagewithe.png')} />
            <Image 
      style={toggle
        ? style.dio
        : style.dioOFF}
      source={toggle 
        ? require('./assets/icons/diocolor.png') 
        : require('./assets/icons/diome-white.png')} />
</TouchableOpacity>
        
  </View>
  );
};

export default App;

const style = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: 'black',
    alignItems: 'center',
    justifyContent: 'center',
  },
  containerLigth: {
    flex: 1,
    backgroundColor: 'white',
    alignItems: 'center',
    justifyContent: 'center',
  },
  ligthingOn: {
    resizeMode: 'contain',
    alignSelf: 'center',
    width: 400,
    height: 400,
  },

ligthingOff: {
  resizeMode: 'contain',
  alignSelf: 'center',
  width: 200,
  height: 200,
},
  dio: {
   alignSelf: 'center',
   width: 150,
   height: 50,
  },
  dioOFF: {
    resizeMode: 'contain',
    alignSelf: 'center',
    width: 150,
    height: 150,
   },
});