import "package:flutter/material.dart";
import 'pages/shopanda_category.dart';
import 'pages/shopanda_home.dart';
import 'pages/shopanda_hotProduct.dart';
import 'pages/shopanda_login.dart';
import 'pages/shopanda_shoppingCar.dart';

class NavigatorBottomBar extends StatefulWidget {
  @override
  _NavigatorBottomBarState createState() => _NavigatorBottomBarState();
}

class _NavigatorBottomBarState extends State<NavigatorBottomBar> {

  int currentPageIndex = 0;
  List<Widget> pageList = List();
  @override
  void initState(){
    pageList
      ..add(homePage())
      ..add(categoryPage())
      ..add(hotProductPage())
      ..add(shoppingCarPage())
      ..add(loginPage());
    super.initState();
  }
  final bottomBarColors = Colors.grey;

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Shopanda'),
        centerTitle: true,
        backgroundColor: Colors.red,
      ),
      body: pageList[currentPageIndex],
      bottomNavigationBar: BottomNavigationBar(
          items:[
            BottomNavigationBarItem(
                icon: Icon(
                    Icons.home_outlined,
                    color: bottomBarColors
                ),
                title: Text(
                  '首页',
                  style: TextStyle(
                      color: bottomBarColors
                  ),
                )
            ),
            BottomNavigationBarItem(
                icon: Icon(
                    Icons.list,
                    color: bottomBarColors
                ),
                title: Text(
                  '分类',
                  style: TextStyle(
                      color: bottomBarColors
                  ),
                )
            ),
            BottomNavigationBarItem(
                icon: Icon(
                    Icons.local_fire_department,
                    color: Colors.red
                ),
                title: Text(
                  '热销',
                  style: TextStyle(
                      color: bottomBarColors
                  ),
                )
            ),
            BottomNavigationBarItem(
                icon: Icon(
                    Icons.shopping_cart_rounded,
                    color: bottomBarColors
                ),
                title: Text(
                  '购物车',
                  style: TextStyle(
                      color: bottomBarColors
                  ),
                )
            ),
            BottomNavigationBarItem(
                icon: Icon(
                    Icons.person,
                    color: bottomBarColors
                ),
                title: Text(
                  '未登入',
                  style: TextStyle(
                      color: bottomBarColors
                  ),
                )
            )
          ],
          currentIndex: currentPageIndex,
          onTap: (int index){
            setState(() {
              currentPageIndex = index;
            });
          },
          type:BottomNavigationBarType.fixed
      ),
    );
  }
}
