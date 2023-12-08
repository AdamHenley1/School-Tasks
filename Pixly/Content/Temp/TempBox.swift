//
//  ArtBox.swift
//  amosity
//
//  Created by Adam Mason on 02/06/2023.
//

import SwiftUI

struct TempBox: View {
    @State private var showTempView = false
    var body: some View {
        ZStack(alignment: .topTrailing){
            Button(action: { showTempView = true }) {
                    Image(systemName: "gear")
                        .resizable()
                        .scaledToFit()
                }
                .frame(width: 100,height: 1020)
            NavigationLink("", destination:  TempView(), isActive: $showTempView)
            }
            .offset(y:120)
        }
    }


struct ArtBox_Previews: PreviewProvider {
    static var previews: some View {
        TempBox()
    }
}
