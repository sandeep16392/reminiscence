import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { AboutComponent } from './about/about.component';
import { NavigationComponent } from './navigation/navigation.component';
import { FeaturesComponent } from './features/features.component';
import { CategoriesComponent } from './categories/categories.component';
import { StoriesComponent } from './stories/stories.component';
import { RegisterComponent } from './register/register.component';
import { FooterComponent } from './footer/footer.component';
import { PopupComponent } from './popup/popup.component';
import { GalleryComponent } from './gallery/gallery.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    AboutComponent,
    NavigationComponent,
    FeaturesComponent,
    CategoriesComponent,
    StoriesComponent,
    RegisterComponent,
    FooterComponent,
    PopupComponent,
    GalleryComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
