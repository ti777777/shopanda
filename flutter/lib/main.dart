import "package:flutter/material.dart";
import "NavigatorBottomBar.dart";

void main() => runApp(shopanda());

class shopanda extends StatelessWidget {

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
        title: '熊猫商城',
        theme: ThemeData.light(),
        home: NavigatorBottomBar()
    );
  }
}

