//
//  TempView.swift
//  amosity
//
//  Created by Adam Mason on 02/06/2023.
//

import SwiftUI

struct TempView: View {
    var columns = [GridItem(.adaptive(minimum: 160),spacing: 20)]
    var body: some View{
        NavigationStack{
            ScrollView(.vertical, showsIndicators: false) {
                LazyVGrid(columns: columns, spacing: 20){
                    TempBox()
                }
                .padding()
            }
            .overlay(
                NavigationBar(title: "Temp",Searching: false, Settings: false)
            )
                .background(Color(red: 0, green: 0, blue: 0))
        }
    }
 }


struct TempView_Previews: PreviewProvider {
    static var previews: some View {
        TempView()
    }
}
