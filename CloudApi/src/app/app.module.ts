import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule } from "@angular/router"
import {ToolbarModule} from 'primeng/toolbar';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { ApiComponent } from './api/api.component';
import { ToolbarComponent } from './toolbar/toolbar.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    ApiComponent,
    ToolbarComponent
  ],
  imports: [
    BrowserModule,
    ToolbarModule,
    RouterModule.forRoot([
      {path : 'home', component: HomeComponent},
      {path: "", redirectTo: "home", pathMatch:"full" },
      {path : 'api', component: ApiComponent}
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
