import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';

import { HttpClientModule } from '@angular/common/http';
import { HttpClientInMemoryWebApiModule } from 'angular-in-memory-web-api';
import { InMemoryDataService }  from './services/in-memory-data.service';
import { GanttComponent } from './components/gantt/gantt.component';
import { PropertiesComponent } from './components/properties/properties.component';
import { InventoryComponent } from './components/inventory/inventory.component';
import { AppRoutingModule } from './app.routing.module';
import { ProjectsComponent } from './components/projects/projects.component';
import { PersonnelComponent } from './components/personnel/personnel.component';
import { PersonnelAddComponent } from './components/personnel/personnelAdd/personnelAdd.component';

@NgModule({
  declarations: [
    AppComponent,
    GanttComponent,
    PropertiesComponent,
    InventoryComponent,
    ProjectsComponent,
    PersonnelComponent,
    PersonnelAddComponent
  ],
  imports: [
    HttpClientModule,
    BrowserModule,
    HttpClientInMemoryWebApiModule.forRoot(InMemoryDataService),
    AppRoutingModule 
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
