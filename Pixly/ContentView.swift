//
//  ContentView.swift
//  Project 1 (SwiftUI)
//
//  Created by Adam Mason on 01/06/2023.
//

import SwiftUI
import UIKit

struct ContentView: View {
    @State var selection = 0
    init() {
        let color = UIColor(red: 0.8156862745098039, green: 0.8156862745098039, blue: 0.8156862745098039, alpha: 1.0)
        let bgcolor = UIColor(red: 0.09803921568627451, green: 0, blue: 0.19607843137254902, alpha: 1)
        UITabBar.appearance().backgroundColor = bgcolor
        UITabBar.appearance().unselectedItemTintColor = color
    }

    var body: some View {
    
        VStack() {
            TabView(selection: $selection){
                HomeView()
                    .tabItem {
                        if selection == 0 {
                            Image(systemName: "house.fill")
                                        }
                        else {
                            Image(systemName: "house")
                                .environment(\.symbolVariants, .none)
    
                                        }
                    }
                    .tag(0)
                    //.background(.ultraThickMaterial)
                SearchView()
                    .tabItem {
                        if selection == 1 {
                            Image(systemName: "magnifyingglass.circle.fill")
                                        }
                        else {
                            Image(systemName: "magnifyingglass.circle")
                                .environment(\.symbolVariants, .none)
                                        }
                    }
                    .tag(1)
                ProfileView()
                    .tabItem {
                        if selection == 2 {
                            Image(systemName: "paintpalette.fill")
                                        }
                        else {
                            Image(systemName: "paintpalette")
                                .environment(\.symbolVariants, .none)
                                        }
                    }
                    .tag(2)
                    //.background(.ultraThickMaterial)
                DarkRoomView()
                    .tabItem {
                        if selection == 3 {
                            Image(systemName: "rotate.3d.fill")
                                        }
                        else {
                            Image(systemName: "rotate.3d")
                                .environment(\.symbolVariants, .none)
                                        }
                    }
                    .tag(3)
            }
            //.blur(radius: 20)
            .accentColor(Color(red: 0.8156862745098039, green: 0.8156862745098039, blue: 0.8156862745098039))
            //.frame(height: 70)
            //.frame(maxHeight: .infinity, alignment: .bottom)
       }
    }
}

struct ContentView_Previews: PreviewProvider {
    static var previews: some View {
        ContentView()
    }
}
