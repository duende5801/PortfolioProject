import { BrowserModule } from '@angular/platform-browser';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {NgbModule} from '@ng-bootstrap/ng-bootstrap';
import { NgModule } from '@angular/core';
import {SidebarModule} from 'primeng/sidebar';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './views/header/header.component';
import { RoutingWindowComponent } from './views/routing-window/routing-window.component';
import { LeftPanelComponent } from './views/left-panel/left-panel.component';
import { RightPanelComponent } from './views/right-panel/right-panel.component';
import { AboutMePanelComponent } from './views/about-me-panel/about-me-panel.component';


@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    RoutingWindowComponent,
    LeftPanelComponent,
    RightPanelComponent,
    AboutMePanelComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    NgbModule,
    SidebarModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
